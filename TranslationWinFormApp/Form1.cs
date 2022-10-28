using System.Text;

namespace TranslationWinFormApp
{
    // Delete files from folder, i getpracticeword så förekommer inte samma ord igen förrän hela listan är körd,
    //om man har många språk i en lista så kan man välja vilka språk man ska träna på i getpractice.
    public partial class Form1 : Form
    {
        private WordList? currentList = null;
        private Word? pWord = null;
        static string? pathToTranslationsFolder = WordList.pathToFolder;
        private string? _fileName = string.Empty;
        string? newWord = String.Empty;
        string? wordToRemove = String.Empty;
        int selectedrowindex = 0;
        int LNselectedrowindex = 0;
        int selectedcolumnindex = 0;
        private int rowIndex = 0;
        private int wordCounter = 0;
        private int correctAnswers = 0;
        private double procent = 0.0;
        private bool IsFileSaved = true;
        private bool isFormClosing = false;
        private bool isSavingOK = false;
        private bool switchedListName = false;
        private bool OkToShowWords = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListNames.Items.AddRange(WordList.GetLists());
            dgwShowWords.ReadOnly = false;

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            string dir = pathToTranslationsFolder;
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

        }

        private void ListNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListNames.SelectedItems.Count > 0)
            {
                if (switchedListName)
                    CheckIfFileIsSaved();

                if (OkToShowWords)
                {
                    LNselectedrowindex = ListNames.SelectedIndex;
                    switchedListName = true;
                    dgwShowWords.Columns.Clear();
                    dgwShowWords.Rows.Clear();
                    buttonAdd.Enabled = true;
                    this.Text = "Form1";

                    _fileName = ListNames.Items[ListNames.SelectedIndex].ToString();
                    currentList = WordList.LoadList(_fileName);

                    for (int i = 0; i < currentList.Languages.Length; i++)
                    {
                        dgwShowWords.Columns.Add(currentList.Languages[i].ToString(), currentList.Languages[i].ToString());
                    }

                    currentList.List(0, PrintWord);

                    if (dgwShowWords.Rows.Count > 0)
                    {
                        dgwShowWords.Rows[0].Selected = false;
                        buttonPractice.Enabled = true;
                    }
                    else
                    {
                        buttonPractice.Enabled = false;
                    }
                }
            }
        }

        void CheckIfFileIsSaved()
        {
            if (!IsFileSaved)
            {
                if (MessageBox.Show("Do you want to save unsaved progress?", "Save?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SaveFile();
                }
                else
                {
                    IsFileSaved = true;
                    switchedListName = true;
                    OkToShowWords = true;
                }
            }
        }
        void GetLists()
        {
            ListNames.Items.Clear();
            ListNames.Items.AddRange(WordList.GetLists());
        }

        void PrintWord(string[] translations)
        {
            rowIndex = dgwShowWords.Rows.Add();

            for (int i = 0; i < currentList.Languages.Length; i++)
            {
                dgwShowWords.Rows[rowIndex].Cells[currentList.Languages[i]].Value = translations[i];
                dgwShowWords.Rows[rowIndex].ReadOnly = true;
            }
        }

        private void dgwShowWords_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwShowWords.SelectedCells.Count > 0)
            {
                selectedrowindex = dgwShowWords.SelectedCells[0].RowIndex;
                selectedcolumnindex = dgwShowWords.SelectedCells[0].ColumnIndex;
                wordToRemove = dgwShowWords.Rows[selectedrowindex].Cells[currentList.Languages[selectedcolumnindex]].FormattedValue.ToString();

                buttonRemove.Enabled = true;
            }
            else
            {
                buttonRemove.Enabled = false;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

            int count = dgwShowWords.SelectedRows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    currentList.Remove(selectedcolumnindex, wordToRemove);
                    dgwShowWords.Rows.RemoveAt(this.dgwShowWords.SelectedRows[0].Index);
                    currentList.Save();
                }
            }

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dgwShowWords.Rows.Insert(0);
            IsFileSaved = false;
            this.Text = "Form1*";
        }
        private void buttonPractice_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            getPracticeWord();
            buttonNewWord.Enabled = false;

        }

        void getPracticeWord()
        {
            pWord = currentList.GetWordToPractice();
            labelPracticeWord.Text = $"\"{pWord}\" to \"{currentList.Languages[pWord.ToLanguage].ToString()}\"";
        }
        private void textBoxUserGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonNewWord.Enabled = true;
                textBoxUserGuess.Enabled = false;

                if (textBoxUserGuess.Text == pWord.Translations[1])
                {
                    tabPage2.BackColor = Color.Chartreuse;
                    correctAnswers++;
                    wordCounter++;
                    labelResult.Visible = true;
                    labelResult.Text = "Correct!!";
                }
                else
                {
                    tabPage2.BackColor = Color.Red;
                    wordCounter++;
                    labelResult.Visible = true;
                    labelResult.Text = "Wrong!!";
                }
                procent = ((double)correctAnswers / (double)wordCounter) * 100;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        void SaveFile()
        {
            bool breakWholeLoop = false;
            if (!IsFileSaved)
            {
                foreach (DataGridViewRow row in dgwShowWords.Rows)
                {
                    if (!breakWholeLoop)
                    {

                        for (int i = 0; i < currentList.Languages.Length; i++)
                        {
                            if (row.Cells[currentList.Languages[i]].FormattedValue.ToString() != "")
                            {
                                isSavingOK = true;
                            }
                            else
                            {
                                isSavingOK = false;
                                breakWholeLoop = true;
                                break;
                            }

                        }
                    }
                    else
                        break;
                }
            }
            if (isSavingOK)
            {
                RefreshList();
                currentList.Save();
                IsFileSaved = true;
                this.Text = "Form1";
                OkToShowWords = true;
            }
            else
            {
                MessageBox.Show("Could not save file!", "Error", MessageBoxButtons.OK);
                IsFileSaved = true;
            }
        }

        void RefreshList()
        {
            List<string>? addWord = new();
            List<Word>? RefreshedList = new List<Word>();

            foreach (DataGridViewRow row in dgwShowWords.Rows)
            {
                for (int i = 0; i < currentList.Languages.Length; i++)
                {
                    if (row.Cells[currentList.Languages[i]].FormattedValue.ToString() != "")
                        addWord.Add(row.Cells[currentList.Languages[i]].FormattedValue.ToString());

                }
                currentList.Add(addWord.ToArray());
                addWord.Clear();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my labb3 result of a translation app. v1.0.", "Translation app", MessageBoxButtons.OK);
        }
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFileForm _newFileForm = new();

            if (_newFileForm.ShowDialog() == DialogResult.OK)
            {
                List<string> newFileLanguages = new();
                newFileLanguages.Add(_newFileForm.Language1);
                newFileLanguages.Add(_newFileForm.Language2);

                if (string.IsNullOrEmpty(_newFileForm.Language3)) newFileLanguages.Add(_newFileForm.Language3);

                if (string.IsNullOrEmpty(_newFileForm.Language4)) newFileLanguages.Add(_newFileForm.Language4);

                if (string.IsNullOrEmpty(_newFileForm.Language5)) newFileLanguages.Add(_newFileForm.Language5);


                createNewFile(_newFileForm.fileName, newFileLanguages.ToArray());

                GetLists();
            }

        }

        private void createNewFile(string fileName, params string[] langStrings)
        {
            string pathWithFileName = Path.Combine(WordList.pathToFolder, fileName + ".dat");

            if (!File.Exists(pathWithFileName))
            {
                fileCreate(pathWithFileName, langStrings);
            }
            else
            {
                if (MessageBox.Show($"{fileName} already exists. Do you want to overwrite it?", "Save file",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    fileCreate(pathWithFileName, langStrings);
                }
            }

        }

        void fileCreate(string path, string[] newFileLanguage)
        {
            using (FileStream fs = File.Create(path))
            {
                byte[] bufferLanguage = new UTF8Encoding(true).GetBytes($"{string.Join(";", newFileLanguage)};");
                fs.Write(bufferLanguage, 0, bufferLanguage.Length);
            }
        }

        private void buttonExitPractice_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to quit?", "Quit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tabControl1.SelectedIndex = 0;
                MessageBox.Show($"You got {Math.Round(procent, 2)}% correct. Total words: {wordCounter}", "Result");
                wordCounter = 0;
                correctAnswers = 0;
            }
        }

        private void buttonNewWord_Click(object sender, EventArgs e)
        {
            getPracticeWord();
            textBoxUserGuess.Text = "";
            buttonNewWord.Enabled = false;
            tabPage2.BackColor = Color.White;
            textBoxUserGuess.Enabled = true;
            labelResult.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsFileSaved && !isFormClosing)
            {
                DialogResult close = MessageBox.Show("Do you want to save unsaved progress?", "Save?", MessageBoxButtons.YesNo);

                if (close == DialogResult.Yes)
                {
                    SaveFile();
                    Close();
                }
                if (close == DialogResult.No)
                {
                    isFormClosing = true;
                    Close();
                }
            }
        }
    }
}