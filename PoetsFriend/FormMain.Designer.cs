namespace PoetsFriend {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFormatFont = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.txtPoem = new RhymeLib.RhymeAssistTextbox();
      this.toolStripMenuItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
      this.englishToolStripMenuItemEnglish = new System.Windows.Forms.ToolStripMenuItem();
      this.frenchToolStripMenuItemFrench = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuFormat,
            this.toolStripMenuItemLanguage,
            this.mnuHelp});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(556, 28);
      this.menuStrip1.TabIndex = 6;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // mnuFile
      // 
      this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuFileQuit});
      this.mnuFile.Name = "mnuFile";
      this.mnuFile.Size = new System.Drawing.Size(44, 24);
      this.mnuFile.Text = "File";
      // 
      // mnuFileOpen
      // 
      this.mnuFileOpen.Name = "mnuFileOpen";
      this.mnuFileOpen.Size = new System.Drawing.Size(135, 26);
      this.mnuFileOpen.Text = "Open";
      this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
      // 
      // mnuFileSave
      // 
      this.mnuFileSave.Name = "mnuFileSave";
      this.mnuFileSave.Size = new System.Drawing.Size(135, 26);
      this.mnuFileSave.Text = "Save";
      this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
      // 
      // mnuFileSaveAs
      // 
      this.mnuFileSaveAs.Name = "mnuFileSaveAs";
      this.mnuFileSaveAs.Size = new System.Drawing.Size(135, 26);
      this.mnuFileSaveAs.Text = "Save As";
      this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
      // 
      // mnuFileQuit
      // 
      this.mnuFileQuit.Name = "mnuFileQuit";
      this.mnuFileQuit.Size = new System.Drawing.Size(135, 26);
      this.mnuFileQuit.Text = "Quit";
      this.mnuFileQuit.Click += new System.EventHandler(this.mnuFileQuit_Click);
      // 
      // mnuFormat
      // 
      this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFormatFont});
      this.mnuFormat.Name = "mnuFormat";
      this.mnuFormat.Size = new System.Drawing.Size(68, 24);
      this.mnuFormat.Text = "Format";
      // 
      // mnuFormatFont
      // 
      this.mnuFormatFont.Name = "mnuFormatFont";
      this.mnuFormatFont.Size = new System.Drawing.Size(113, 26);
      this.mnuFormatFont.Text = "Font";
      this.mnuFormatFont.Click += new System.EventHandler(this.mnuFormatFont_Click);
      // 
      // mnuHelp
      // 
      this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
      this.mnuHelp.Name = "mnuHelp";
      this.mnuHelp.Size = new System.Drawing.Size(53, 24);
      this.mnuHelp.Text = "Help";
      // 
      // mnuHelpAbout
      // 
      this.mnuHelpAbout.Name = "mnuHelpAbout";
      this.mnuHelpAbout.Size = new System.Drawing.Size(181, 26);
      this.mnuHelpAbout.Text = "About";
      this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
      // 
      // txtPoem
      // 
      this.txtPoem.AcceptsTab = true;
      this.txtPoem.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtPoem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPoem.Location = new System.Drawing.Point(0, 28);
      this.txtPoem.Margin = new System.Windows.Forms.Padding(4);
      this.txtPoem.Multiline = true;
      this.txtPoem.Name = "txtPoem";
      this.txtPoem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtPoem.Size = new System.Drawing.Size(556, 377);
      this.txtPoem.TabIndex = 5;
      this.txtPoem.TextChanged += new System.EventHandler(this.txtPoem_TextChanged);
      // 
      // toolStripMenuItemLanguage
      // 
      this.toolStripMenuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItemEnglish,
            this.frenchToolStripMenuItemFrench});
      this.toolStripMenuItemLanguage.Name = "toolStripMenuItemLanguage";
      this.toolStripMenuItemLanguage.Size = new System.Drawing.Size(86, 24);
      this.toolStripMenuItemLanguage.Text = "Language";
      // 
      // englishToolStripMenuItemEnglish
      // 
      this.englishToolStripMenuItemEnglish.Checked = true;
      this.englishToolStripMenuItemEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
      this.englishToolStripMenuItemEnglish.Name = "englishToolStripMenuItemEnglish";
      this.englishToolStripMenuItemEnglish.Size = new System.Drawing.Size(181, 26);
      this.englishToolStripMenuItemEnglish.Text = "English";
      // 
      // frenchToolStripMenuItemFrench
      // 
      this.frenchToolStripMenuItemFrench.Name = "frenchToolStripMenuItemFrench";
      this.frenchToolStripMenuItemFrench.Size = new System.Drawing.Size(181, 26);
      this.frenchToolStripMenuItemFrench.Text = "French";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(556, 405);
      this.Controls.Add(this.txtPoem);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FormMain";
      this.ShowIcon = false;
      this.Text = "Poet\'s Friend";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private RhymeLib.RhymeAssistTextbox txtPoem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileQuit;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatFont;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLanguage;
    private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItemEnglish;
    private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItemFrench;
  }
}

