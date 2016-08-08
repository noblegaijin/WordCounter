using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCounter
{
    public partial class WordCounter : Form
    {

        const string DEFAULT_OPEN_FILE_DIALOG_DIRECTORY = "C:\\users\\%username%\\downloads";
        string _entireText = "";
        string _cleansedOutput = "";
        private bool _previouslyRan;

        public WordCounter()
        {
            InitializeComponent();
            txtNoOfWords.Enabled = false;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\users\%username%\downloads",
                RestoreDirectory = true,
                AutoUpgradeEnabled = false,
                Filter = "csv files (.csv)|*.csv|txt files(.txt)|*.txt",
                FilterIndex = 1,
                Multiselect = false
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                EnableRemoveControls();
                string fileName = dialog.FileName;
                ReportOriginalOutput(File.ReadAllText(fileName));
            }

        }

        private void ReportOriginalOutput(string output)
        {
            _entireText = CleanupText(output);
            txtResult.Text = _entireText;
            MatchCollection matchs = Regex.Matches(_entireText, @"[\S]+");
            txtNoOfWords.Text = matchs.Count.ToString();
        }

        private string CleanupText(string text)
        {
            text = text.ToLower();
            return Regex.Replace(Regex.Replace(Regex.Replace(text, "[\\.^$,\"_•/()+:#\x00ae=<>-]", " "), @"[\n\r]", " "), "[ ]{2,}", " ").Trim();
        }

        private void EnableRemoveControls()
        {
            txtRemove.Enabled = true;
            btnRemove.Enabled = true;
            txtUnwanted.Enabled = true;
            btnReset.Enabled = true;
            txtResult.Enabled = true;
        }

        private void RemovePhraseFromOutput()
        {
            int num4;
            string text = "";
            if (_previouslyRan)
            {
                text = this.txtCleansed.Text;
            }
            else
            {
                text = this._entireText;
            }
            char[] separator = new char[] { ' ' };
            string[] source = text.Split(separator);
            char[] chArray2 = new char[] { ' ' };
            string[] strArray2 = this.CleanupText(this.txtRemove.Text).Split(chArray2);
            List<int> list = new List<int>();
            List<string> list2 = new List<string>();
            bool flag = false;
            for (int i = 0; i < source.Count<string>(); i = num4 + 1)
            {
                if ((i + strArray2.Count<string>()) <= source.Count<string>())
                {
                    for (int j = 0; j < strArray2.Count<string>(); j = num4 + 1)
                    {
                        list2.Add(source[i + j]);
                        list.Add(i + j);
                        num4 = j;
                    }
                    int num2 = 0;
                    for (int k = 0; k < list2.Count<string>(); k = num4 + 1)
                    {
                        if (list2[k] != strArray2[k])
                        {
                            break;
                        }
                        num4 = num2;
                        num2 = num4 + 1;
                        num4 = k;
                    }
                    if (num2 == strArray2.Count<string>())
                    {
                        if (!flag)
                        {
                            flag = true;
                        }
                        else
                        {
                            this.txtUnwanted.Visible = true;
                            foreach (int num6 in list)
                            {
                                source[num6] = "";
                            }
                            for (int m = 0; m < strArray2.Length; m = num4 + 1)
                            {
                                TextBox txtUnwanted;
                                if (m == (strArray2.Length - 1))
                                {
                                    txtUnwanted = this.txtUnwanted;
                                    txtUnwanted.Text = txtUnwanted.Text + strArray2[m] + ", ";
                                }
                                else
                                {
                                    txtUnwanted = this.txtUnwanted;
                                    txtUnwanted.Text = txtUnwanted.Text + strArray2[m] + " ";
                                }
                                num4 = m;
                            }
                        }
                    }
                    list2.Clear();
                    list.Clear();
                }
                num4 = i;
            }
            string output = "";
            foreach (string str3 in source)
            {
                if (str3 != "")
                {
                    output = output + str3 + " ";
                }
            }
            ReportCleansedOutput(output);
            _previouslyRan = true;
        }

        private void ReportCleansedOutput(string output)
        {
            txtCleansed.Text = output;
            MatchCollection matchs = Regex.Matches(output, @"[\S]+");
            txtNoOfWordsAfter.Text = matchs.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            base.Controls.Clear();
            InitializeComponent();
            _previouslyRan = false;
            _entireText = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Only perform if there is something to remove
            if (txtRemove.Text != "")
            {
                RemovePhraseFromOutput();
                txtRemove.Text = "";
            }
                
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
