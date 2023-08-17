using System;
using System.IO;
using System.Windows.Forms;

using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.PowerPoint;

namespace OfficeToPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog.SelectedPath;
                textBox1.Text = selectedFolderPath; // Update the textBox1 with the selected folder path
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string folderPath = textBox1.Text;

            if (Directory.Exists(folderPath))
            {
                ConvertDocumentsToPDF(folderPath);
                MessageBox.Show("Conversion completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid folder path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertDocumentsToPDF(string folderPath)
        {
            string[] documentExtensions = { ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx" };

            foreach (string filePath in Directory.GetFiles(folderPath))
            {
                //MessageBox.Show(filePath, "name", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string fileExtension = Path.GetExtension(filePath).ToLower();
                //MessageBox.Show(fileExtension, "extension", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Array.Exists(documentExtensions, ext => ext == fileExtension))
                {
                    string pdfFilePath = Path.ChangeExtension(filePath, ".pdf");

                    if (File.Exists(pdfFilePath))
                    {
                        File.Delete(pdfFilePath);
                    }
                    //MessageBox.Show(pdfFilePath, "pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    object application = null;

                    try
                    {
                        if (fileExtension == ".doc" || fileExtension == ".docx")
                        {
                            //MessageBox.Show("doc Entry", "name", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            application = new Microsoft.Office.Interop.Word.Application();
                            Document document = ((Microsoft.Office.Interop.Word.Application)application).Documents.Open(filePath);
                            document.ExportAsFixedFormat(pdfFilePath, WdExportFormat.wdExportFormatPDF);
                            document.Close();
                        }
                        else if (fileExtension == ".xls" || fileExtension == ".xlsx")
                        {
                            //MessageBox.Show("excel Entry", "name", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            application = new Microsoft.Office.Interop.Excel.Application();
                            Workbook workbook = ((Microsoft.Office.Interop.Excel.Application)application).Workbooks.Open(filePath);
                            workbook.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, pdfFilePath);
                            workbook.Close();
                        }
                        else if (fileExtension == ".ppt" || fileExtension == ".pptx")
                        {
                            MessageBox.Show("ppt Entry", "name", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            application = new Microsoft.Office.Interop.PowerPoint.Application();
                            Presentation presentation = ((Microsoft.Office.Interop.PowerPoint.Application)application).Presentations.Open(filePath);
                            presentation.ExportAsFixedFormat(pdfFilePath, PpFixedFormatType.ppFixedFormatTypePDF);
                            presentation.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error converting {Path.GetFileName(filePath)}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (application != null)
                        {
                            application.GetType().InvokeMember("Quit", System.Reflection.BindingFlags.InvokeMethod, null, application, null);
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(application);
                        }
                    }
                }
            }
        }
    }
}
