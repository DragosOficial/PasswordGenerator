namespace PasswordGenerator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.includeNums = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generateGUID = new System.Windows.Forms.CheckBox();
            this.charTypeProbEqualButton = new System.Windows.Forms.RadioButton();
            this.restoreDefault = new System.Windows.Forms.Button();
            this.specCharacters = new System.Windows.Forms.TextBox();
            this.passwordLengthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.includeLowercase = new System.Windows.Forms.CheckBox();
            this.includeCaptial = new System.Windows.Forms.CheckBox();
            this.includeSpecCharctor = new System.Windows.Forms.CheckBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.savePasswordButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            this.includeNums.AutoSize = true;
            this.includeNums.Location = new System.Drawing.Point(1, 29);
            this.includeNums.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.includeNums.Name = "includeNums";
            this.includeNums.Size = new System.Drawing.Size(76, 24);
            this.includeNums.TabIndex = 0;
            this.includeNums.Text = "Liczby";
            this.includeNums.UseVisualStyleBackColor = true;

            this.groupBox1.Controls.Add(this.generateGUID);
            this.groupBox1.Controls.Add(this.charTypeProbEqualButton);
            this.groupBox1.Controls.Add(this.restoreDefault);
            this.groupBox1.Controls.Add(this.specCharacters);
            this.groupBox1.Controls.Add(this.passwordLengthBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.includeLowercase);
            this.groupBox1.Controls.Add(this.includeCaptial);
            this.groupBox1.Controls.Add(this.includeSpecCharctor);
            this.groupBox1.Controls.Add(this.includeNums);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(413, 198);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje";

            this.generateGUID.AutoSize = true;
            this.generateGUID.Location = new System.Drawing.Point(15, 166);
            this.generateGUID.Name = "generateGUID";
            this.generateGUID.Size = new System.Drawing.Size(226, 24);
            this.generateGUID.TabIndex = 7;
            this.generateGUID.Text = "Generuj identyfikator GUID";
            this.generateGUID.UseVisualStyleBackColor = true;
            this.generateGUID.CheckedChanged += new System.EventHandler(this.generateGUID_CheckedChanged);

            this.charTypeProbEqualButton.AutoSize = true;
            this.charTypeProbEqualButton.Location = new System.Drawing.Point(15, 137);
            this.charTypeProbEqualButton.Margin = new System.Windows.Forms.Padding(2);
            this.charTypeProbEqualButton.Name = "charTypeProbEqualButton";
            this.charTypeProbEqualButton.Size = new System.Drawing.Size(363, 24);
            this.charTypeProbEqualButton.TabIndex = 6;
            this.charTypeProbEqualButton.TabStop = true;
            this.charTypeProbEqualButton.Text = "Każdy znak ma równe szanse na pojawienia się";
            this.charTypeProbEqualButton.UseVisualStyleBackColor = true;

            this.restoreDefault.Location = new System.Drawing.Point(296, 59);
            this.restoreDefault.Margin = new System.Windows.Forms.Padding(2);
            this.restoreDefault.Name = "restoreDefault";
            this.restoreDefault.Size = new System.Drawing.Size(109, 34);
            this.restoreDefault.TabIndex = 5;
            this.restoreDefault.Text = "Zresetuj";
            this.restoreDefault.UseVisualStyleBackColor = true;
            this.restoreDefault.Click += new System.EventHandler(this.restoreDefault_Click);

            this.specCharacters.Location = new System.Drawing.Point(139, 63);
            this.specCharacters.Margin = new System.Windows.Forms.Padding(2);
            this.specCharacters.Name = "specCharacters";
            this.specCharacters.Size = new System.Drawing.Size(148, 27);
            this.specCharacters.TabIndex = 4;

            this.passwordLengthBox.Location = new System.Drawing.Point(117, 101);
            this.passwordLengthBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordLengthBox.MaxLength = 3;
            this.passwordLengthBox.Name = "passwordLengthBox";
            this.passwordLengthBox.Size = new System.Drawing.Size(91, 27);
            this.passwordLengthBox.TabIndex = 3;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Długośc hasła：";

            this.includeLowercase.AutoSize = true;
            this.includeLowercase.Location = new System.Drawing.Point(250, 29);
            this.includeLowercase.Margin = new System.Windows.Forms.Padding(2);
            this.includeLowercase.Name = "includeLowercase";
            this.includeLowercase.Size = new System.Drawing.Size(108, 24);
            this.includeLowercase.TabIndex = 1;
            this.includeLowercase.Text = "Małe litery";
            this.includeLowercase.UseVisualStyleBackColor = true;

            this.includeCaptial.AutoSize = true;
            this.includeCaptial.Location = new System.Drawing.Point(117, 29);
            this.includeCaptial.Margin = new System.Windows.Forms.Padding(2);
            this.includeCaptial.Name = "includeCaptial";
            this.includeCaptial.Size = new System.Drawing.Size(108, 24);
            this.includeCaptial.TabIndex = 1;
            this.includeCaptial.Text = "Duże litery";
            this.includeCaptial.UseVisualStyleBackColor = true;

            this.includeSpecCharctor.AutoSize = true;
            this.includeSpecCharctor.Location = new System.Drawing.Point(0, 63);
            this.includeSpecCharctor.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.includeSpecCharctor.Name = "includeSpecCharctor";
            this.includeSpecCharctor.Size = new System.Drawing.Size(141, 24);
            this.includeSpecCharctor.TabIndex = 0;
            this.includeSpecCharctor.Text = "Znaki specjalne";
            this.includeSpecCharctor.UseVisualStyleBackColor = true;
            this.includeSpecCharctor.CheckedChanged += new System.EventHandler(this.includeSpecCharctor_CheckedChanged);

            this.GenerateButton.Location = new System.Drawing.Point(139, 229);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(159, 34);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generuj hasło";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);

            this.passwordBox.Location = new System.Drawing.Point(11, 279);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.ReadOnly = true;
            this.passwordBox.Size = new System.Drawing.Size(412, 27);
            this.passwordBox.TabIndex = 3;

            this.CopyButton.Location = new System.Drawing.Point(26, 321);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(2);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(164, 34);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "Skopiuj do schowka";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);

            this.aboutButton.Location = new System.Drawing.Point(185, 401);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(2);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(109, 34);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "O aplikacji...";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);

            this.exitButton.Location = new System.Drawing.Point(305, 401);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 34);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Wyjście";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);

            this.savePasswordButton.Location = new System.Drawing.Point(240, 321);
            this.savePasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.savePasswordButton.Name = "savePasswordButton";
            this.savePasswordButton.Size = new System.Drawing.Size(161, 34);
            this.savePasswordButton.TabIndex = 6;
            this.savePasswordButton.Text = "Zapisz do pliku";
            this.savePasswordButton.UseVisualStyleBackColor = true;
            this.savePasswordButton.Click += new System.EventHandler(this.savePasswordButton_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(434, 448);
            this.Controls.Add(this.savePasswordButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator haseł";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onFormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.CheckBox includeNums;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordLengthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox includeLowercase;
        private System.Windows.Forms.CheckBox includeCaptial;
        private System.Windows.Forms.CheckBox includeSpecCharctor;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button savePasswordButton;
        private System.Windows.Forms.TextBox specCharacters;
        private System.Windows.Forms.Button restoreDefault;
        private System.Windows.Forms.RadioButton charTypeProbEqualButton;
        private System.Windows.Forms.CheckBox generateGUID;
    }
}

