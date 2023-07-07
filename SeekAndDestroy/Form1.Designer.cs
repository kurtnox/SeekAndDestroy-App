namespace SeekAndDestroy
{
    partial class seekAndDestroy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seekAndDestroy));
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileScrap = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.editBold = new System.Windows.Forms.ToolStripMenuItem();
            this.editItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.fontLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.fontCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.editUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConvert = new System.Windows.Forms.ToolStripMenuItem();
            this.converDocxToPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.convertPdfToDocx = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openedFiles = new System.Windows.Forms.TextBox();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.replaceInput = new System.Windows.Forms.TextBox();
            this.openFilesBtn = new System.Windows.Forms.Button();
            this.backupFiles = new System.Windows.Forms.Button();
            this.searchResult = new System.Windows.Forms.TextBox();
            this.replaceResult = new System.Windows.Forms.TextBox();
            this.docxToPdf = new System.Windows.Forms.Button();
            this.pdfToDocx = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNew,
            this.fileOpen,
            this.fileSave,
            this.fileScrap,
            this.exitProgram});
            this.menuFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(47, 24);
            this.menuFile.Text = "&File";
            // 
            // fileNew
            // 
            this.fileNew.Name = "fileNew";
            this.fileNew.Size = new System.Drawing.Size(224, 26);
            this.fileNew.Text = "&New";
            this.fileNew.Click += new System.EventHandler(this.fileNew_Click);
            // 
            // fileOpen
            // 
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.Size = new System.Drawing.Size(224, 26);
            this.fileOpen.Text = "&Open";
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // fileSave
            // 
            this.fileSave.Name = "fileSave";
            this.fileSave.Size = new System.Drawing.Size(224, 26);
            this.fileSave.Text = "&Backup files";
            this.fileSave.Click += new System.EventHandler(this.fileSave_Click);
            // 
            // fileScrap
            // 
            this.fileScrap.Name = "fileScrap";
            this.fileScrap.Size = new System.Drawing.Size(224, 26);
            this.fileScrap.Text = "&Scrap";
            this.fileScrap.Click += new System.EventHandler(this.fileScrap_Click);
            // 
            // exitProgram
            // 
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.Size = new System.Drawing.Size(224, 26);
            this.exitProgram.Text = "&Exit";
            this.exitProgram.Click += new System.EventHandler(this.exitProgram_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBold,
            this.editItalic,
            this.editUnderline,
            this.fontSizeOptions});
            this.menuEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(49, 24);
            this.menuEdit.Text = "&Edit";
            // 
            // editBold
            // 
            this.editBold.Name = "editBold";
            this.editBold.Size = new System.Drawing.Size(224, 26);
            this.editBold.Text = "&Bold";
            this.editBold.Click += new System.EventHandler(this.editBold_Click);
            // 
            // editItalic
            // 
            this.editItalic.Name = "editItalic";
            this.editItalic.Size = new System.Drawing.Size(224, 26);
            this.editItalic.Text = "&Italic";
            this.editItalic.Click += new System.EventHandler(this.editItalic_Click);
            // 
            // fontSizeOptions
            // 
            this.fontSizeOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSmall,
            this.fontMedium,
            this.fontLarge,
            this.fontCustom});
            this.fontSizeOptions.Name = "fontSizeOptions";
            this.fontSizeOptions.Size = new System.Drawing.Size(224, 26);
            this.fontSizeOptions.Text = "&Font Size";
            this.fontSizeOptions.Click += new System.EventHandler(this.fontSizeOptions_Click);
            // 
            // fontSmall
            // 
            this.fontSmall.Name = "fontSmall";
            this.fontSmall.Size = new System.Drawing.Size(224, 26);
            this.fontSmall.Text = "&Small";
            // 
            // fontMedium
            // 
            this.fontMedium.Name = "fontMedium";
            this.fontMedium.Size = new System.Drawing.Size(224, 26);
            this.fontMedium.Text = "&Medium";
            // 
            // fontLarge
            // 
            this.fontLarge.Name = "fontLarge";
            this.fontLarge.Size = new System.Drawing.Size(224, 26);
            this.fontLarge.Text = "&Large";
            // 
            // fontCustom
            // 
            this.fontCustom.Name = "fontCustom";
            this.fontCustom.Size = new System.Drawing.Size(224, 26);
            this.fontCustom.Text = "&Custom";
            // 
            // editUnderline
            // 
            this.editUnderline.Name = "editUnderline";
            this.editUnderline.Size = new System.Drawing.Size(224, 26);
            this.editUnderline.Text = "&Underline";
            this.editUnderline.Click += new System.EventHandler(this.editUnderline_Click);
            // 
            // menuConvert
            // 
            this.menuConvert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.converDocxToPdf,
            this.convertPdfToDocx});
            this.menuConvert.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuConvert.Name = "menuConvert";
            this.menuConvert.Size = new System.Drawing.Size(77, 24);
            this.menuConvert.Text = "&Convert";
            // 
            // converDocxToPdf
            // 
            this.converDocxToPdf.Name = "converDocxToPdf";
            this.converDocxToPdf.Size = new System.Drawing.Size(224, 26);
            this.converDocxToPdf.Text = ".DOCX to .PDF";
            this.converDocxToPdf.Click += new System.EventHandler(this.converDocxToPdf_Click);
            // 
            // convertPdfToDocx
            // 
            this.convertPdfToDocx.Name = "convertPdfToDocx";
            this.convertPdfToDocx.Size = new System.Drawing.Size(224, 26);
            this.convertPdfToDocx.Text = ".PDF to .DOCX";
            this.convertPdfToDocx.Click += new System.EventHandler(this.convertPdfToDocx_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuConvert});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openedFiles
            // 
            this.openedFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openedFiles.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.openedFiles.Location = new System.Drawing.Point(12, 123);
            this.openedFiles.Multiline = true;
            this.openedFiles.Name = "openedFiles";
            this.openedFiles.ReadOnly = true;
            this.openedFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.openedFiles.Size = new System.Drawing.Size(929, 234);
            this.openedFiles.TabIndex = 1;
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(13, 403);
            this.searchInput.Multiline = true;
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(148, 52);
            this.searchInput.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.Info;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(167, 403);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(134, 52);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.SystemColors.Info;
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReplace.Location = new System.Drawing.Point(813, 403);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(125, 52);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // replaceInput
            // 
            this.replaceInput.Location = new System.Drawing.Point(659, 403);
            this.replaceInput.Multiline = true;
            this.replaceInput.Name = "replaceInput";
            this.replaceInput.Size = new System.Drawing.Size(148, 52);
            this.replaceInput.TabIndex = 4;
            // 
            // openFilesBtn
            // 
            this.openFilesBtn.BackColor = System.Drawing.SystemColors.Info;
            this.openFilesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFilesBtn.Location = new System.Drawing.Point(12, 72);
            this.openFilesBtn.Name = "openFilesBtn";
            this.openFilesBtn.Size = new System.Drawing.Size(336, 45);
            this.openFilesBtn.TabIndex = 6;
            this.openFilesBtn.Text = "Select DocX Files";
            this.openFilesBtn.UseVisualStyleBackColor = false;
            this.openFilesBtn.Click += new System.EventHandler(this.openFilesBtn_Click);
            // 
            // backupFiles
            // 
            this.backupFiles.BackColor = System.Drawing.SystemColors.Info;
            this.backupFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupFiles.Location = new System.Drawing.Point(574, 72);
            this.backupFiles.Name = "backupFiles";
            this.backupFiles.Size = new System.Drawing.Size(367, 45);
            this.backupFiles.TabIndex = 7;
            this.backupFiles.Text = "Backup your files befor editing!";
            this.backupFiles.UseVisualStyleBackColor = false;
            this.backupFiles.Click += new System.EventHandler(this.backupFiles_Click);
            // 
            // searchResult
            // 
            this.searchResult.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.searchResult.Location = new System.Drawing.Point(13, 461);
            this.searchResult.Multiline = true;
            this.searchResult.Name = "searchResult";
            this.searchResult.ReadOnly = true;
            this.searchResult.Size = new System.Drawing.Size(288, 26);
            this.searchResult.TabIndex = 8;
            // 
            // replaceResult
            // 
            this.replaceResult.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.replaceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceResult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.replaceResult.Location = new System.Drawing.Point(659, 461);
            this.replaceResult.Multiline = true;
            this.replaceResult.Name = "replaceResult";
            this.replaceResult.ReadOnly = true;
            this.replaceResult.Size = new System.Drawing.Size(279, 26);
            this.replaceResult.TabIndex = 9;
            // 
            // docxToPdf
            // 
            this.docxToPdf.BackColor = System.Drawing.SystemColors.Info;
            this.docxToPdf.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.docxToPdf.Location = new System.Drawing.Point(137, 576);
            this.docxToPdf.Name = "docxToPdf";
            this.docxToPdf.Size = new System.Drawing.Size(288, 55);
            this.docxToPdf.TabIndex = 10;
            this.docxToPdf.Text = "Convert DOCX to PDF";
            this.docxToPdf.UseVisualStyleBackColor = false;
            this.docxToPdf.Click += new System.EventHandler(this.docxToPdf_Click);
            // 
            // pdfToDocx
            // 
            this.pdfToDocx.BackColor = System.Drawing.SystemColors.Info;
            this.pdfToDocx.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pdfToDocx.Location = new System.Drawing.Point(574, 576);
            this.pdfToDocx.Name = "pdfToDocx";
            this.pdfToDocx.Size = new System.Drawing.Size(279, 55);
            this.pdfToDocx.TabIndex = 11;
            this.pdfToDocx.Text = "Convert PDF to DOCX";
            this.pdfToDocx.UseVisualStyleBackColor = false;
            this.pdfToDocx.Click += new System.EventHandler(this.pdfToDocx_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(422, 461);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 46);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // seekAndDestroy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(953, 679);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pdfToDocx);
            this.Controls.Add(this.docxToPdf);
            this.Controls.Add(this.replaceResult);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.backupFiles);
            this.Controls.Add(this.openFilesBtn);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.replaceInput);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.openedFiles);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "seekAndDestroy";
            this.Text = "S&D";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem fileNew;
        private System.Windows.Forms.ToolStripMenuItem fileOpen;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        private System.Windows.Forms.ToolStripMenuItem fileScrap;
        private System.Windows.Forms.ToolStripMenuItem exitProgram;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem editBold;
        private System.Windows.Forms.ToolStripMenuItem editItalic;
        private System.Windows.Forms.ToolStripMenuItem fontSizeOptions;
        private System.Windows.Forms.ToolStripMenuItem fontSmall;
        private System.Windows.Forms.ToolStripMenuItem fontMedium;
        private System.Windows.Forms.ToolStripMenuItem fontLarge;
        private System.Windows.Forms.ToolStripMenuItem fontCustom;
        private System.Windows.Forms.ToolStripMenuItem editUnderline;
        private System.Windows.Forms.ToolStripMenuItem menuConvert;
        private System.Windows.Forms.ToolStripMenuItem converDocxToPdf;
        private System.Windows.Forms.ToolStripMenuItem convertPdfToDocx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox openedFiles;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox replaceInput;
        private System.Windows.Forms.Button openFilesBtn;
        private System.Windows.Forms.Button backupFiles;
        private System.Windows.Forms.TextBox searchResult;
        private System.Windows.Forms.TextBox replaceResult;
        private System.Windows.Forms.Button docxToPdf;
        private System.Windows.Forms.Button pdfToDocx;
        private System.Windows.Forms.Button btnRefresh;
    }
}

