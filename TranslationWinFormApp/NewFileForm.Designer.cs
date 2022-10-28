namespace TranslationWinFormApp
{
    partial class NewFileForm
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
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelL1 = new System.Windows.Forms.Label();
            this.labelL2 = new System.Windows.Forms.Label();
            this.labelL3 = new System.Windows.Forms.Label();
            this.textBoxL1 = new System.Windows.Forms.TextBox();
            this.textBoxL2 = new System.Windows.Forms.TextBox();
            this.textBoxL3 = new System.Windows.Forms.TextBox();
            this.textBoxL4 = new System.Windows.Forms.TextBox();
            this.textBoxL5 = new System.Windows.Forms.TextBox();
            this.labelL5 = new System.Windows.Forms.Label();
            this.labelL4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            this.buttonDone.Enabled = false;
            this.buttonDone.Location = new System.Drawing.Point(130, 384);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(112, 34);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 384);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(12, 9);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(91, 25);
            this.labelFileName.TabIndex = 2;
            this.labelFileName.Text = "File name:";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(12, 37);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(230, 31);
            this.textBoxFileName.TabIndex = 3;
            this.textBoxFileName.TextChanged += new System.EventHandler(this.textBoxFileName_TextChanged);
            // 
            // labelL1
            // 
            this.labelL1.AutoSize = true;
            this.labelL1.Location = new System.Drawing.Point(12, 71);
            this.labelL1.Name = "labelL1";
            this.labelL1.Size = new System.Drawing.Size(108, 25);
            this.labelL1.TabIndex = 4;
            this.labelL1.Text = "Language 1:";
            // 
            // labelL2
            // 
            this.labelL2.AutoSize = true;
            this.labelL2.Location = new System.Drawing.Point(12, 133);
            this.labelL2.Name = "labelL2";
            this.labelL2.Size = new System.Drawing.Size(108, 25);
            this.labelL2.TabIndex = 5;
            this.labelL2.Text = "Language 2:";
            // 
            // labelL3
            // 
            this.labelL3.AutoSize = true;
            this.labelL3.Location = new System.Drawing.Point(10, 195);
            this.labelL3.Name = "labelL3";
            this.labelL3.Size = new System.Drawing.Size(108, 25);
            this.labelL3.TabIndex = 6;
            this.labelL3.Text = "Language 3:";
            this.labelL3.Visible = false;
            // 
            // textBoxL1
            // 
            this.textBoxL1.Location = new System.Drawing.Point(10, 99);
            this.textBoxL1.Name = "textBoxL1";
            this.textBoxL1.Size = new System.Drawing.Size(230, 31);
            this.textBoxL1.TabIndex = 7;
            this.textBoxL1.TextChanged += new System.EventHandler(this.textBoxL1_TextChanged);
            // 
            // textBoxL2
            // 
            this.textBoxL2.Location = new System.Drawing.Point(12, 161);
            this.textBoxL2.Name = "textBoxL2";
            this.textBoxL2.Size = new System.Drawing.Size(230, 31);
            this.textBoxL2.TabIndex = 8;
            this.textBoxL2.TextChanged += new System.EventHandler(this.textBoxL2_TextChanged);
            // 
            // textBoxL3
            // 
            this.textBoxL3.Location = new System.Drawing.Point(12, 223);
            this.textBoxL3.Name = "textBoxL3";
            this.textBoxL3.Size = new System.Drawing.Size(230, 31);
            this.textBoxL3.TabIndex = 9;
            this.textBoxL3.Visible = false;
            this.textBoxL3.TextChanged += new System.EventHandler(this.textBoxL3_TextChanged);
            // 
            // textBoxL4
            // 
            this.textBoxL4.Location = new System.Drawing.Point(12, 285);
            this.textBoxL4.Name = "textBoxL4";
            this.textBoxL4.Size = new System.Drawing.Size(230, 31);
            this.textBoxL4.TabIndex = 10;
            this.textBoxL4.Visible = false;
            this.textBoxL4.TextChanged += new System.EventHandler(this.textBoxL4_TextChanged);
            // 
            // textBoxL5
            // 
            this.textBoxL5.Location = new System.Drawing.Point(12, 347);
            this.textBoxL5.Name = "textBoxL5";
            this.textBoxL5.Size = new System.Drawing.Size(230, 31);
            this.textBoxL5.TabIndex = 11;
            this.textBoxL5.Visible = false;
            this.textBoxL5.TextChanged += new System.EventHandler(this.textBoxL5_TextChanged);
            // 
            // labelL5
            // 
            this.labelL5.AutoSize = true;
            this.labelL5.Location = new System.Drawing.Point(12, 319);
            this.labelL5.Name = "labelL5";
            this.labelL5.Size = new System.Drawing.Size(108, 25);
            this.labelL5.TabIndex = 12;
            this.labelL5.Text = "Language 5:";
            this.labelL5.Visible = false;
            // 
            // labelL4
            // 
            this.labelL4.AutoSize = true;
            this.labelL4.Location = new System.Drawing.Point(12, 257);
            this.labelL4.Name = "labelL4";
            this.labelL4.Size = new System.Drawing.Size(108, 25);
            this.labelL4.TabIndex = 13;
            this.labelL4.Text = "Language 4:";
            this.labelL4.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(203, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 31);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // NewFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 427);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelL4);
            this.Controls.Add(this.labelL5);
            this.Controls.Add(this.textBoxL5);
            this.Controls.Add(this.textBoxL4);
            this.Controls.Add(this.textBoxL3);
            this.Controls.Add(this.textBoxL2);
            this.Controls.Add(this.textBoxL1);
            this.Controls.Add(this.labelL3);
            this.Controls.Add(this.labelL2);
            this.Controls.Add(this.labelL1);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New File";
            this.Load += new System.EventHandler(this.NewFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonDone;
        private Button buttonCancel;
        private Label labelFileName;
        private TextBox textBoxFileName;
        private Label labelL1;
        private Label labelL2;
        private Label labelL3;
        private TextBox textBoxL1;
        private TextBox textBoxL2;
        private TextBox textBoxL3;
        private TextBox textBoxL4;
        private TextBox textBoxL5;
        private Label labelL5;
        private Label labelL4;
        private NumericUpDown numericUpDown1;
    }
}