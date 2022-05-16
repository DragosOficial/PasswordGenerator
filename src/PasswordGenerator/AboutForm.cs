using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            this.Text = String.Format("O aplikacji...");
            this.labelProductName.Text = "Nazwa: Password Generator";
            this.labelVersion.Text = String.Format("Wersja: 1.0");
            this.labelCopyright.Text = "Copyright © Dragos";
            this.labelCompileTime.Text = "Ostatnia kompilacja: 2022/05/08";
            this.textBoxDescription.Text = "Ten program służy do generowania haseł.";
        }
    }
}
