# CMDlineAppXLSXtoPDF

A simple C# command-line utility to **recalculate** and **convert Excel (.xls, .xlsx)** files to **PDF** using [Aspose.Cells](https://products.aspose.com/cells/).

> ✅ Also supports recalculating formulas and saving back to Excel instead of PDF.

---

## ⚠️ Licensing

This app uses **Aspose.Cells**, which is **not free**. You can run the app in **evaluation mode**, but the output will include watermarks.

- To remove evaluation watermarks, purchase a license from Aspose.
- Place your license file as `aspose.lic` in the **same directory where the app runs**.

---

## 🛠 Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- Works on Windows (other OSes possible via cross-platform build)

---

## 🔧 Build Instructions

### 1. Build (for development/testing):

```bash
dotnet build -c Release
```

### 2. Publish (for deployment):

```bash
dotnet publish -c Release -r win-x64 --self-contained false
```

> You can change the runtime identifier (`-r`) to `linux-x64`, `osx-arm64`, etc.

---

## 🚀 Usage

### Convert to PDF (default behavior):
```bash
ExcelToPdfConverter.exe path\to\input.xlsx path\to\output.pdf
```

### Recalculate formulas and output Excel:
```bash
ExcelToPdfConverter.exe path\to\input.xlsx path\to\output.xlsx
```

### Supported output formats:
- `.pdf` – converts Excel to PDF
- `.xlsx` – recalculates and saves as modern Excel format
- `.xls` – recalculates and saves as legacy Excel format

> If no output file is provided, the app will default to generating a `.pdf`.

---

## 🧪 Testing in VS Code

You can test the app directly in VS Code:

```bash
dotnet run -- path\to\input.xlsx path\to\output.pdf
```

> Use `--` to pass arguments to the program.

To debug with arguments, configure `launch.json` with `args`.

---

## 📂 Example

```bash
dotnet run -- "data\report.xlsx" "exports\report.pdf"
dotnet run -- "data\sales.xls" "exports\sales_recalculated.xls"
```

---

## 📃 License File Handling

Place your `aspose.lic` file in the **same folder** as the `.exe` or publish directory.

If the license file is not found, the app will continue in **evaluation mode** with limitations.

---

Made with ❤️ and Excel.
