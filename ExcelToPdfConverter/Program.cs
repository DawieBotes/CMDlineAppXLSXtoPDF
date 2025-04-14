using System;
using System.IO;
using Aspose.Cells;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: ExcelConverter <input.xls or input.xlsx> [output.pdf|output.xlsx]");
            return;
        }

        string inputFilePath = args[0];
        string outputFilePath = args.Length > 1
            ? args[1]
            : Path.ChangeExtension(inputFilePath, ".pdf");  // default to PDF

        try
        {
            ApplyLicenseIfAvailable("aspose.lic");

            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine($"Error: The input file '{inputFilePath}' does not exist.");
                return;
            }

            Workbook workbook = new Workbook(inputFilePath);
            workbook.CalculateFormula();

            // Determine output format based on extension
            string extension = Path.GetExtension(outputFilePath).ToLowerInvariant();
            SaveFormat format;

            switch (extension)
            {
                case ".pdf":
                    format = SaveFormat.Pdf;
                    break;
                case ".xlsx":
                    format = SaveFormat.Xlsx;
                    break;
                case ".xls":
                    format = SaveFormat.Excel97To2003;
                    break;
                default:
                    Console.WriteLine("Unsupported output file extension. Please use .pdf, .xlsx, or .xls.");
                    return;
            }

            workbook.Save(outputFilePath, format);
            Console.WriteLine($"Success! File saved at: {outputFilePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private static void ApplyLicenseIfAvailable(string licenseFilePath)
    {
        try
        {
            if (File.Exists(licenseFilePath) && new FileInfo(licenseFilePath).Length > 0)
            {
                License license = new License();
                license.SetLicense(licenseFilePath);
                Console.WriteLine("Aspose license applied successfully.");
            }
            else
            {
                Console.WriteLine("License file not found or empty. Using evaluation mode.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error applying license: {ex.Message}");
        }
    }
}
