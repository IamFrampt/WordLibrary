namespace TranslationWinFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListNames = new System.Windows.Forms.ListBox();
            this.dgwShowWords = new System.Windows.Forms.DataGridView();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonPractice = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelPracticeWord = new System.Windows.Forms.Label();
            this.labelblank = new System.Windows.Forms.Label();
            this.buttonExitPractice = new System.Windows.Forms.Button();
            this.buttonNewWord = new System.Windows.Forms.Button();
            this.textBoxUserGuess = new System.Windows.Forms.TextBox();
            this.PracticeMode = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowWords)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.newFileToolStripMenuItem.Text = "New file";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(114, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ListNames
            // 
            this.ListNames.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListNames.FormattingEnabled = true;
            this.ListNames.ItemHeight = 15;
            this.ListNames.Location = new System.Drawing.Point(2, 2);
            this.ListNames.Margin = new System.Windows.Forms.Padding(2);
            this.ListNames.Name = "ListNames";
            this.ListNames.Size = new System.Drawing.Size(185, 299);
            this.ListNames.TabIndex = 1;
            this.ListNames.SelectedIndexChanged += new System.EventHandler(this.ListNames_SelectedIndexChanged);
            // 
            // dgwShowWords
            // 
            this.dgwShowWords.AllowUserToAddRows = false;
            this.dgwShowWords.AllowUserToDeleteRows = false;
            this.dgwShowWords.AllowUserToResizeColumns = false;
            this.dgwShowWords.AllowUserToResizeRows = false;
            this.dgwShowWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwShowWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwShowWords.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwShowWords.Location = new System.Drawing.Point(289, 2);
            this.dgwShowWords.Margin = new System.Windows.Forms.Padding(2);
            this.dgwShowWords.Name = "dgwShowWords";
            this.dgwShowWords.ReadOnly = true;
            this.dgwShowWords.RowHeadersVisible = false;
            this.dgwShowWords.RowHeadersWidth = 62;
            this.dgwShowWords.RowTemplate.Height = 33;
            this.dgwShowWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwShowWords.Size = new System.Drawing.Size(638, 299);
            this.dgwShowWords.TabIndex = 4;
            this.dgwShowWords.SelectionChanged += new System.EventHandler(this.dgwShowWords_SelectionChanged);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(190, 95);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(97, 20);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(190, 124);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(97, 20);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonPractice
            // 
            this.buttonPractice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPractice.Enabled = false;
            this.buttonPractice.Location = new System.Drawing.Point(190, 148);
            this.buttonPractice.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPractice.Name = "buttonPractice";
            this.buttonPractice.Size = new System.Drawing.Size(97, 20);
            this.buttonPractice.TabIndex = 7;
            this.buttonPractice.Text = "Practice";
            this.buttonPractice.UseVisualStyleBackColor = true;
            this.buttonPractice.Click += new System.EventHandler(this.buttonPractice_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 331);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.ListNames);
            this.tabPage1.Controls.Add(this.buttonPractice);
            this.tabPage1.Controls.Add(this.dgwShowWords);
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.buttonRemove);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(929, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.labelResult);
            this.tabPage2.Controls.Add(this.labelPracticeWord);
            this.tabPage2.Controls.Add(this.labelblank);
            this.tabPage2.Controls.Add(this.buttonExitPractice);
            this.tabPage2.Controls.Add(this.buttonNewWord);
            this.tabPage2.Controls.Add(this.textBoxUserGuess);
            this.tabPage2.Controls.Add(this.PracticeMode);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(929, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // labelResult
            // 
            this.labelResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResult.BackColor = System.Drawing.Color.Transparent;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelResult.Location = new System.Drawing.Point(149, 232);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(629, 55);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Correct!!";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResult.Visible = false;
            // 
            // labelPracticeWord
            // 
            this.labelPracticeWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPracticeWord.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPracticeWord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelPracticeWord.Location = new System.Drawing.Point(2, 92);
            this.labelPracticeWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPracticeWord.Name = "labelPracticeWord";
            this.labelPracticeWord.Size = new System.Drawing.Size(925, 82);
            this.labelPracticeWord.TabIndex = 8;
            this.labelPracticeWord.Text = "to";
            this.labelPracticeWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelblank
            // 
            this.labelblank.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelblank.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelblank.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelblank.Location = new System.Drawing.Point(2, 47);
            this.labelblank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelblank.Name = "labelblank";
            this.labelblank.Size = new System.Drawing.Size(925, 45);
            this.labelblank.TabIndex = 7;
            this.labelblank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExitPractice
            // 
            this.buttonExitPractice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExitPractice.Location = new System.Drawing.Point(6, 250);
            this.buttonExitPractice.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExitPractice.Name = "buttonExitPractice";
            this.buttonExitPractice.Size = new System.Drawing.Size(139, 49);
            this.buttonExitPractice.TabIndex = 6;
            this.buttonExitPractice.Text = "Exit Practice";
            this.buttonExitPractice.UseVisualStyleBackColor = true;
            this.buttonExitPractice.Click += new System.EventHandler(this.buttonExitPractice_Click);
            // 
            // buttonNewWord
            // 
            this.buttonNewWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewWord.Location = new System.Drawing.Point(782, 250);
            this.buttonNewWord.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewWord.Name = "buttonNewWord";
            this.buttonNewWord.Size = new System.Drawing.Size(139, 49);
            this.buttonNewWord.TabIndex = 5;
            this.buttonNewWord.Text = "New word";
            this.buttonNewWord.UseVisualStyleBackColor = true;
            this.buttonNewWord.Click += new System.EventHandler(this.buttonNewWord_Click);
            // 
            // textBoxUserGuess
            // 
            this.textBoxUserGuess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserGuess.Location = new System.Drawing.Point(365, 188);
            this.textBoxUserGuess.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserGuess.Name = "textBoxUserGuess";
            this.textBoxUserGuess.Size = new System.Drawing.Size(181, 23);
            this.textBoxUserGuess.TabIndex = 1;
            this.textBoxUserGuess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUserGuess_KeyDown);
            // 
            // PracticeMode
            // 
            this.PracticeMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.PracticeMode.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PracticeMode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PracticeMode.Location = new System.Drawing.Point(2, 2);
            this.PracticeMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PracticeMode.Name = "PracticeMode";
            this.PracticeMode.Size = new System.Drawing.Size(925, 45);
            this.PracticeMode.TabIndex = 0;
            this.PracticeMode.Text = "Translate";
            this.PracticeMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 355);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(953, 394);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translation App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowWords)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ListBox ListNames;
        private DataGridView dgwShowWords;
        private Button buttonRemove;
        private Button buttonAdd;
        private Button buttonPractice;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBoxUserGuess;
        private Label PracticeMode;
        private Button buttonExitPractice;
        private Button buttonNewWord;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label labelPracticeWord;
        private Label labelblank;
        private Label labelResult;
    }
}