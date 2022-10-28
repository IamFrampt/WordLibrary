using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TranslationWinFormApp
{
    public partial class NewFileForm : Form
    {

        public string fileName
        {
            get { return textBoxFileName.Text; }
            set { textBoxFileName.Text = value; }
        }

        public string Language1
        {
            get { return textBoxL1.Text; }
            set { textBoxL1.Text = value; }
        }

        public string Language2
        {
            get { return textBoxL2.Text; }
            set { textBoxL2.Text = value; }
        }

        public string Language3
        {
            get { return textBoxL3.Text; }
            set { textBoxL3.Text = value; }
        }

        public string Language4
        {
            get { return textBoxL4.Text; }
            set { textBoxL4.Text = value; }
        }

        public string Language5
        {
            get { return textBoxL5.Text; }
            set { textBoxL5.Text = value; }
        }
        
        public NewFileForm()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBoxL2_TextChanged(object sender, EventArgs e)
        {
            showDoneButton();
        }

        private void textBoxL1_TextChanged(object sender, EventArgs e)
        {
            showDoneButton();
        }



        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {
            showDoneButton();
        }
        void showDoneButton()
        {

            if (textBoxL1.Text == "" || textBoxL2.Text == "" || textBoxFileName.Text == "")
            {
                buttonDone.Enabled = false;
                textBoxL3.Enabled = false;
                textBoxL3.Text = "";
            }
            else
            {
                buttonDone.Enabled = true;
                textBoxL3.Enabled = true;
            }
        }

        private void textBoxL3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxL3.Text))
            {
                textBoxL4.Enabled = true;
            }
            else
            {
                textBoxL4.Enabled = false;
                textBoxL4.Text = "";
            }
        }

        private void textBoxL4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxL4.Text))
            {
                textBoxL5.Enabled = true;
            }
            else
            {
                textBoxL5.Enabled = false;
                textBoxL5.Text = "";
            }
        }
    }
}
