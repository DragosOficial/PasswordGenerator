using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    enum CharType
    {
        CK_NUMBERS,
        CK_CAPTIAL,
        CK_LOWERCASE,
        CK_SPECALCHAR
    }

    public partial class Form1 : Form
    {
        List<CharType> m_optionCheck = new List<CharType>();
        Random m_randon = new Random();
        string m_lastPassword = "";

        public Form1()
        {
            InitializeComponent();
            includeNums.Checked = Properties.Settings.Default.IncludeNum;
            includeCaptial.Checked = Properties.Settings.Default.IncludeCapital;
            includeLowercase.Checked = Properties.Settings.Default.IncludeLowercase;
            includeSpecCharctor.Checked = Properties.Settings.Default.IncludeSpecCharator;
            passwordLengthBox.Text = Properties.Settings.Default.PasswordLength;
            specCharacters.Text = Properties.Settings.Default.SpecCharacters;
            charTypeProbEqualButton.Checked = Properties.Settings.Default.CharTypeProbEqual;
            generateGUID.Checked = Properties.Settings.Default.GenerateGUID;
            SetControlEnableState();
        }

        private void GetOptionState()
        {
            m_optionCheck.Clear();
            if (includeNums.Checked)
                m_optionCheck.Add(CharType.CK_NUMBERS);
            if (includeCaptial.Checked)
                m_optionCheck.Add(CharType.CK_CAPTIAL);
            if (includeLowercase.Checked)
                m_optionCheck.Add(CharType.CK_LOWERCASE);
            if (includeSpecCharctor.Checked)
                m_optionCheck.Add(CharType.CK_SPECALCHAR);
        }

        private void SetControlEnableState()
        {
            specCharacters.Enabled = includeSpecCharctor.Checked && !generateGUID.Checked;
            restoreDefault.Enabled = includeSpecCharctor.Checked && !generateGUID.Checked;

            includeNums.Enabled = !generateGUID.Checked;
            includeCaptial.Enabled = !generateGUID.Checked;
            includeLowercase.Enabled = !generateGUID.Checked;
            includeSpecCharctor.Enabled = !generateGUID.Checked;
            label1.Enabled = !generateGUID.Checked;
            passwordLengthBox.Enabled = !generateGUID.Checked;
            charTypeProbEqualButton.Enabled = !generateGUID.Checked;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (generateGUID.Checked)
            {
                string newGuid = Guid.NewGuid().ToString();
                passwordBox.Text = newGuid;
                return;
            }

            GetOptionState();
            passwordBox.Text = "";
            if (passwordLengthBox.Text.Length == 0)
            {
                MessageBox.Show("Wprowadź długość generowanego hasła!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(m_optionCheck.Count == 0)
            {
                MessageBox.Show("Wybierz typ znaków do uwzględnienia!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int passwordLength = 0;
            try
            {
                passwordLength = int.Parse(passwordLengthBox.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Można wprowadzić tylko liczby do pola 'Długość hasła'!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(passwordLength == 0)
            {
                MessageBox.Show("Długość hasła nie może wynosić 0!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (charTypeProbEqualButton.Checked)
            {
                for (int i = 0; i< passwordLength; i++)
                {
                    int index = m_randon.Next(m_optionCheck.Count);
                    CharType charType = m_optionCheck[index];
                    char currentChar = '\0';
                    switch(charType)
                    {
                        case CharType.CK_NUMBERS:
                            currentChar = Convert.ToChar(m_randon.Next(48, 58));
                            break;
                        case CharType.CK_CAPTIAL:
                            currentChar = Convert.ToChar(m_randon.Next(65, 91));
                            break;
                        case CharType.CK_LOWERCASE:
                            currentChar = Convert.ToChar(m_randon.Next(97, 123));
                            break;
                        case CharType.CK_SPECALCHAR:
                            int randon = m_randon.Next(specCharacters.Text.Length);
                            currentChar = specCharacters.Text[randon];
                            break;
                    }
                    passwordBox.Text += currentChar;
                }
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if(passwordBox.TextLength > 0)
            {
                passwordBox.SelectAll();
                passwordBox.Copy();
                MessageBox.Show("Hasło zostało skopiowane do schowka.", "Wskazówka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void onKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                GenerateButton_Click(new object(), new EventArgs());
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            (new AboutForm()).ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void savePasswordButton_Click(object sender, EventArgs e)
        {
            if(passwordBox.TextLength > 0 && passwordBox.Text != m_lastPassword)
            {
                StreamWriter streamWriter = new StreamWriter(".\\password.log", true, Encoding.UTF8);
                streamWriter.Write(DateTime.Now.ToString());
                streamWriter.Write("：");
                streamWriter.WriteLine(passwordBox.Text);
                streamWriter.Close();
                m_lastPassword = passwordBox.Text;
                MessageBox.Show("Hasło zostało zapisane do pliku password.log w folderze zawierającym.", "Wskazówka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void onFormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.IncludeNum = includeNums.Checked;
            Properties.Settings.Default.IncludeCapital = includeCaptial.Checked;
            Properties.Settings.Default.IncludeLowercase = includeLowercase.Checked;
            Properties.Settings.Default.IncludeSpecCharator = includeSpecCharctor.Checked;
            Properties.Settings.Default.PasswordLength = passwordLengthBox.Text;
            Properties.Settings.Default.SpecCharacters = specCharacters.Text;
            Properties.Settings.Default.CharTypeProbEqual = charTypeProbEqualButton.Checked;
            Properties.Settings.Default.GenerateGUID = generateGUID.Checked;
            Properties.Settings.Default.Save();
        }

        private void restoreDefault_Click(object sender, EventArgs e)
        {
            specCharacters.Text = "~!@#$%^&*()_-+={}[]|\\<>/?";
        }

        private void includeSpecCharctor_CheckedChanged(object sender, EventArgs e)
        {
            SetControlEnableState();
        }

        private void generateGUID_CheckedChanged(object sender, EventArgs e)
        {
            SetControlEnableState();
        }
    }
}
