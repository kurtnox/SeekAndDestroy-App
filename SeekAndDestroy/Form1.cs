using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Aspose.Words;
using Body = DocumentFormat.OpenXml.Wordprocessing.Body;
using Document = Aspose.Words.Document;
using System.Text.RegularExpressions;


namespace SeekAndDestroy
{
    public partial class seekAndDestroy : Form
    {
        public seekAndDestroy()
        {
            InitializeComponent();
        }

        int fontSize = 8;
        string fontName = "MS Sans Serif";

        public void ChangeFont() //functionality to edit buttons
        {
            FontStyle newFont = FontStyle.Regular;

            if (editBold.Checked)
            {
                newFont = FontStyle.Bold;
            }
            if (editItalic.Checked)
            {
                newFont = FontStyle.Italic;
            }
            replaceInput.Font = new System.Drawing.Font(fontName, fontSize, newFont);

        }



        // MENU FILE FUNCTIONALITY----------------------------------------------------------------------------
        private void fileNew_Click(object sender, EventArgs e) //file New BTN
        {
            if (MessageBox.Show("Are you sure you want to start a over?", "New File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                openedFiles.Text = string.Empty;
            }
        }

        private void exitProgram_Click(object sender, EventArgs e) //Exit program button
        {
            if (MessageBox.Show("Are you sure you want to exit the program?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        //


        //OPEN FILE BUTTON
        private void openFilesBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Word Document (*.docx)|*docx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> selectedFiles = new List<string>(openFileDialog.FileNames);

                //clear textbox
                openedFiles.Text = "";



                foreach (string file in selectedFiles)
                {
                    openedFiles.Text = string.Join(Environment.NewLine + Environment.NewLine, selectedFiles);
                }
            }

        }

        private void fileOpen_Click(object sender, EventArgs e)
        {
            openFilesBtn_Click(sender, e);
        }


        //BACKUP THINGS---------------------------------------------------
        private void fileSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string destinationFolderPath = folderBrowserDialog.SelectedPath;
                List<string> backupDirectories = new List<string>();

                foreach (string selectedFile in openedFiles.Lines)
                {
                    if (!string.IsNullOrWhiteSpace(selectedFile))
                    {
                        string fileName = Path.GetFileName(selectedFile);
                        string fileExtension = Path.GetExtension(selectedFile);

                        string backupFileName = $"{Path.GetFileNameWithoutExtension(selectedFile)}-backup.docx";
                        string destinationFilePath = Path.Combine(destinationFolderPath, backupFileName);

                        File.Copy(selectedFile, destinationFilePath);

                        backupDirectories.Add(Path.GetFileNameWithoutExtension(selectedFile));
                    }
                }

                string backupDirectoriesFilePath = Path.Combine(destinationFolderPath, "backup_directories.txt");
                File.WriteAllLines(backupDirectoriesFilePath, backupDirectories.Select(dir => $"{dir}-backup.docx"));
            }
        }

        private void backupFiles_Click(object sender, EventArgs e)
        {
            fileSave_Click(sender, e);
        }


        // SCRAP ---------------------------------
        private void fileScrap_Click(object sender, EventArgs e)
        {
            openedFiles.Text = "";
        }


        //FIND and replace WORD----------------------------------------
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string searchWord = searchInput.Text.Trim();
                if (string.IsNullOrEmpty(searchWord))
                {
                    MessageBox.Show("Please enter a search word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int totalCount = 0;

                foreach (string file in openedFiles.Lines)
                {
                    if (!string.IsNullOrWhiteSpace(file))
                    {
                        using (WordprocessingDocument document = WordprocessingDocument.Open(file, false))
                        {
                            WordprocessingDocumentType type = document.DocumentType;
                            if (type == WordprocessingDocumentType.Document)
                            {
                                Body body = document.MainDocumentPart.Document.Body;
                                int count = CountWordInstances(body, searchWord);
                                totalCount += count;
                            }
                        }
                    }
                }

                searchResult.Text = $"Total instances found: {totalCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CountWordInstances(Body body, string searchWord)
        {
            int count = 0;
            foreach (var text in body.Descendants<Text>())
            {
                count += CountWordOccurrences(text.Text, searchWord, StringComparison.OrdinalIgnoreCase);
            }
            return count;
        }

        private int CountWordOccurrences(string text, string searchWord, StringComparison comparisonType)
        {
            int count = 0;
            int index = 0;
            while ((index = text.IndexOf(searchWord, index, comparisonType)) != -1)
            {
                count++;
                index += searchWord.Length;
            }
            return count;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            try
            {
                string searchWord = searchInput.Text.Trim();
                string replaceWord = replaceInput.Text.Trim();
                if (string.IsNullOrEmpty(searchWord))
                {
                    MessageBox.Show("Please enter a search word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int totalCount = 0;

                foreach (string file in openedFiles.Lines)
                {
                    if (!string.IsNullOrWhiteSpace(file))
                    {
                        using (WordprocessingDocument document = WordprocessingDocument.Open(file, true))
                        {
                            WordprocessingDocumentType type = document.DocumentType;
                            if (type == WordprocessingDocumentType.Document)
                            {
                                Body body = document.MainDocumentPart.Document.Body;
                                int count = ReplaceWordInstances(body, searchWord, replaceWord, StringComparison.OrdinalIgnoreCase);
                                totalCount += count;
                            }
                        }
                    }
                }

                // Show confirmation dialog
                DialogResult result = MessageBox.Show($"Total instances found: {totalCount}. Are you sure you want to replace {searchWord} with {replaceWord} {totalCount} times?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    replaceResult.Text = $"Total instances replaced: {totalCount}";
                }
                else
                {
                    replaceResult.Text = "Replacement canceled.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ClearInputFields()
        {
            searchInput.Text = string.Empty;
            replaceInput.Text = string.Empty;
            searchResult.Text = string.Empty;
            replaceResult.Text = string.Empty;

            await Task.Delay(TimeSpan.FromSeconds(3));
        }

        private int ReplaceWordInstances(Body body, string searchWord, string replaceWord, StringComparison comparisonType)
        {
            int count = 0;
            foreach (var text in body.Descendants<Text>())
            {
                string originalText = text.Text;
                string newText = Regex.Replace(originalText, Regex.Escape(searchWord), replaceWord, RegexOptions.IgnoreCase);

                if (originalText != newText)
                {
                    text.Text = newText;
                    count++;
                }
            }
            return count;
        }



        //Convert docx to pdf and back
        private void docxToPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Word Documents|*.docx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    string outputDirectory = string.Empty;
                    string outputFilePath = string.Empty;

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "PDF Files|*.pdf";
                        saveFileDialog.FileName = Path.GetFileNameWithoutExtension(file) + "--PDF";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            outputDirectory = Path.GetDirectoryName(saveFileDialog.FileName);
                            outputFilePath = Path.Combine(outputDirectory, Path.GetFileNameWithoutExtension(saveFileDialog.FileName) + ".pdf");
                        }
                        else
                        {
                            return; // User canceled the save dialog
                        }
                    }

                    try
                    {
                        Document doc = new Document(file);
                        doc.Save(outputFilePath, SaveFormat.Pdf);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while converting the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Conversion complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pdfToDocx_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    // Confirm conversion
                    DialogResult confirmationResult = MessageBox.Show($"Convert {Path.GetFileName(filePath)} to DOCX?", "Confirmation", MessageBoxButtons.YesNo);
                    if (confirmationResult == DialogResult.No)
                    {
                        continue;
                    }

                    // Convert PDF to DOCX
                    Document pdfDocument = new Document(filePath);
                    string outputFileName = Path.GetFileNameWithoutExtension(filePath) + "--DOCX.docx";
                    string outputDirectory = GetOutputDirectory();
                    string outputFilePath = Path.Combine(outputDirectory, outputFileName);
                    pdfDocument.Save(outputFilePath, SaveFormat.Docx);
                }

                MessageBox.Show("Conversion completed successfully.");
            }
        }

        private string GetOutputDirectory()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                return folderBrowserDialog.SelectedPath;
            }

            return null; // Handle when no directory is selected
        }

        private void convertPdfToDocx_Click(object sender, EventArgs e)
        {
            pdfToDocx_Click(sender, e);
        }

        private void converDocxToPdf_Click(object sender, EventArgs e)
        {
            docxToPdf_Click(sender, e);
        }

        private void editBold_Click(object sender, EventArgs e)
        {
            editBold.Checked = !editBold.Checked;
            ChangeFont();
        }

        private void editItalic_Click(object sender, EventArgs e)
        {
            editItalic.Checked = !editItalic.Checked;
            ChangeFont();
        }

        private void editUnderline_Click(object sender, EventArgs e)
        {
            editUnderline.Checked = !editUnderline.Checked;
            ChangeFont();
        }

        private void fontSizeOptions_Click(object sender, EventArgs e)
        {
            string sizeClicked = ((ToolStripMenuItem)sender).Text;
            fontSmall.Checked = false;
            fontMedium.Checked = false;
            fontLarge.Checked = false;

            switch(sizeClicked)
            {
                case "&Small":
                    fontSize = 8;
                    fontSmall.Checked = true;
                    break;
                case "&Medium":
                    fontSize = 12;
                    fontMedium.Checked= true;
                    break;
                case "&Large":
                    fontSize = 16;
                    fontLarge.Checked= true;
                    break;
            }
            ChangeFont();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            searchInput.Text = string.Empty;
            replaceInput.Text = string.Empty;
            searchResult.Text = string.Empty;
            replaceResult.Text = string.Empty;
        }
    }
}
