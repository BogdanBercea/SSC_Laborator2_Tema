namespace ssc_good_homework
{
    partial class Form1
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
            this.comboBoxCipher = new System.Windows.Forms.ComboBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.labelIV = new System.Windows.Forms.Label();
            this.buttonEnc = new System.Windows.Forms.Button();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            this.labelPlainText = new System.Windows.Forms.Label();
            this.labelPlainTextASCII = new System.Windows.Forms.Label();
            this.textBoxPlainHex = new System.Windows.Forms.TextBox();
            this.labelPlainTextHEX = new System.Windows.Forms.Label();
            this.buttonDec = new System.Windows.Forms.Button();
            this.textBoxCipherHex = new System.Windows.Forms.TextBox();
            this.textBoxCipher = new System.Windows.Forms.TextBox();
            this.labelCipherText = new System.Windows.Forms.Label();
            this.labelCipherASCII = new System.Windows.Forms.Label();
            this.labelCipherHEX = new System.Windows.Forms.Label();
            this.buttonEncTime = new System.Windows.Forms.Button();
            this.labelEncTime = new System.Windows.Forms.Label();
            this.buttonDecTime = new System.Windows.Forms.Button();
            this.labelDecTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCipher
            // 
            this.comboBoxCipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCipher.FormattingEnabled = true;
            this.comboBoxCipher.Items.AddRange(new object[] {
            "DES",
            "3DES",
            "Rijndael"});
            this.comboBoxCipher.Location = new System.Drawing.Point(38, 39);
            this.comboBoxCipher.Name = "comboBoxCipher";
            this.comboBoxCipher.Size = new System.Drawing.Size(301, 24);
            this.comboBoxCipher.TabIndex = 0;
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(38, 84);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(301, 50);
            this.buttonGen.TabIndex = 1;
            this.buttonGen.Text = "Genereate Key and IV";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(483, 41);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(461, 22);
            this.textBoxKey.TabIndex = 2;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(480, 21);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(32, 17);
            this.labelKey.TabIndex = 3;
            this.labelKey.Text = "Key";
            // 
            // textBoxIV
            // 
            this.textBoxIV.Location = new System.Drawing.Point(483, 112);
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.Size = new System.Drawing.Size(461, 22);
            this.textBoxIV.TabIndex = 4;
            // 
            // labelIV
            // 
            this.labelIV.AutoSize = true;
            this.labelIV.Location = new System.Drawing.Point(480, 92);
            this.labelIV.Name = "labelIV";
            this.labelIV.Size = new System.Drawing.Size(20, 17);
            this.labelIV.TabIndex = 5;
            this.labelIV.Text = "IV";
            // 
            // buttonEnc
            // 
            this.buttonEnc.Location = new System.Drawing.Point(38, 198);
            this.buttonEnc.Name = "buttonEnc";
            this.buttonEnc.Size = new System.Drawing.Size(301, 53);
            this.buttonEnc.TabIndex = 6;
            this.buttonEnc.Text = "Encrypt";
            this.buttonEnc.UseVisualStyleBackColor = true;
            this.buttonEnc.Click += new System.EventHandler(this.buttonEnc_Click);
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.Location = new System.Drawing.Point(483, 198);
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.Size = new System.Drawing.Size(461, 22);
            this.textBoxPlain.TabIndex = 7;
            // 
            // labelPlainText
            // 
            this.labelPlainText.AutoSize = true;
            this.labelPlainText.Location = new System.Drawing.Point(480, 178);
            this.labelPlainText.Name = "labelPlainText";
            this.labelPlainText.Size = new System.Drawing.Size(70, 17);
            this.labelPlainText.TabIndex = 8;
            this.labelPlainText.Text = "Plain Text";
            // 
            // labelPlainTextASCII
            // 
            this.labelPlainTextASCII.AutoSize = true;
            this.labelPlainTextASCII.Location = new System.Drawing.Point(431, 203);
            this.labelPlainTextASCII.Name = "labelPlainTextASCII";
            this.labelPlainTextASCII.Size = new System.Drawing.Size(41, 17);
            this.labelPlainTextASCII.TabIndex = 9;
            this.labelPlainTextASCII.Text = "ASCII";
            // 
            // textBoxPlainHex
            // 
            this.textBoxPlainHex.Location = new System.Drawing.Point(483, 229);
            this.textBoxPlainHex.Name = "textBoxPlainHex";
            this.textBoxPlainHex.Size = new System.Drawing.Size(461, 22);
            this.textBoxPlainHex.TabIndex = 10;
            // 
            // labelPlainTextHEX
            // 
            this.labelPlainTextHEX.AutoSize = true;
            this.labelPlainTextHEX.Location = new System.Drawing.Point(431, 232);
            this.labelPlainTextHEX.Name = "labelPlainTextHEX";
            this.labelPlainTextHEX.Size = new System.Drawing.Size(36, 17);
            this.labelPlainTextHEX.TabIndex = 11;
            this.labelPlainTextHEX.Text = "HEX";
            // 
            // buttonDec
            // 
            this.buttonDec.Location = new System.Drawing.Point(38, 311);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(301, 51);
            this.buttonDec.TabIndex = 12;
            this.buttonDec.Text = "Decrypt";
            this.buttonDec.UseVisualStyleBackColor = true;
            this.buttonDec.Click += new System.EventHandler(this.buttonDec_Click);
            // 
            // textBoxCipherHex
            // 
            this.textBoxCipherHex.Location = new System.Drawing.Point(483, 340);
            this.textBoxCipherHex.Name = "textBoxCipherHex";
            this.textBoxCipherHex.Size = new System.Drawing.Size(461, 22);
            this.textBoxCipherHex.TabIndex = 13;
            // 
            // textBoxCipher
            // 
            this.textBoxCipher.Location = new System.Drawing.Point(483, 312);
            this.textBoxCipher.Name = "textBoxCipher";
            this.textBoxCipher.Size = new System.Drawing.Size(461, 22);
            this.textBoxCipher.TabIndex = 14;
            // 
            // labelCipherText
            // 
            this.labelCipherText.AutoSize = true;
            this.labelCipherText.Location = new System.Drawing.Point(480, 292);
            this.labelCipherText.Name = "labelCipherText";
            this.labelCipherText.Size = new System.Drawing.Size(80, 17);
            this.labelCipherText.TabIndex = 15;
            this.labelCipherText.Text = "Cipher Text";
            // 
            // labelCipherASCII
            // 
            this.labelCipherASCII.AutoSize = true;
            this.labelCipherASCII.Location = new System.Drawing.Point(431, 315);
            this.labelCipherASCII.Name = "labelCipherASCII";
            this.labelCipherASCII.Size = new System.Drawing.Size(41, 17);
            this.labelCipherASCII.TabIndex = 16;
            this.labelCipherASCII.Text = "ASCII";
            // 
            // labelCipherHEX
            // 
            this.labelCipherHEX.AutoSize = true;
            this.labelCipherHEX.Location = new System.Drawing.Point(431, 343);
            this.labelCipherHEX.Name = "labelCipherHEX";
            this.labelCipherHEX.Size = new System.Drawing.Size(36, 17);
            this.labelCipherHEX.TabIndex = 17;
            this.labelCipherHEX.Text = "HEX";
            // 
            // buttonEncTime
            // 
            this.buttonEncTime.Location = new System.Drawing.Point(38, 442);
            this.buttonEncTime.Name = "buttonEncTime";
            this.buttonEncTime.Size = new System.Drawing.Size(301, 56);
            this.buttonEncTime.TabIndex = 18;
            this.buttonEncTime.Text = "Get Encrypt Time";
            this.buttonEncTime.UseVisualStyleBackColor = true;
            this.buttonEncTime.Click += new System.EventHandler(this.buttonEncTime_Click);
            // 
            // labelEncTime
            // 
            this.labelEncTime.AutoSize = true;
            this.labelEncTime.Location = new System.Drawing.Point(480, 442);
            this.labelEncTime.Name = "labelEncTime";
            this.labelEncTime.Size = new System.Drawing.Size(190, 17);
            this.labelEncTime.TabIndex = 19;
            this.labelEncTime.Text = "Time/Message at encryption:";
            // 
            // buttonDecTime
            // 
            this.buttonDecTime.Location = new System.Drawing.Point(38, 557);
            this.buttonDecTime.Name = "buttonDecTime";
            this.buttonDecTime.Size = new System.Drawing.Size(301, 52);
            this.buttonDecTime.TabIndex = 20;
            this.buttonDecTime.Text = "Get Decrypt Time";
            this.buttonDecTime.UseVisualStyleBackColor = true;
            this.buttonDecTime.Click += new System.EventHandler(this.buttonDecTime_Click);
            // 
            // labelDecTime
            // 
            this.labelDecTime.AutoSize = true;
            this.labelDecTime.Location = new System.Drawing.Point(480, 557);
            this.labelDecTime.Name = "labelDecTime";
            this.labelDecTime.Size = new System.Drawing.Size(171, 17);
            this.labelDecTime.TabIndex = 21;
            this.labelDecTime.Text = "Time/Message at decrypt:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 664);
            this.Controls.Add(this.labelDecTime);
            this.Controls.Add(this.buttonDecTime);
            this.Controls.Add(this.labelEncTime);
            this.Controls.Add(this.buttonEncTime);
            this.Controls.Add(this.labelCipherHEX);
            this.Controls.Add(this.labelCipherASCII);
            this.Controls.Add(this.labelCipherText);
            this.Controls.Add(this.textBoxCipher);
            this.Controls.Add(this.textBoxCipherHex);
            this.Controls.Add(this.buttonDec);
            this.Controls.Add(this.labelPlainTextHEX);
            this.Controls.Add(this.textBoxPlainHex);
            this.Controls.Add(this.labelPlainTextASCII);
            this.Controls.Add(this.labelPlainText);
            this.Controls.Add(this.textBoxPlain);
            this.Controls.Add(this.buttonEnc);
            this.Controls.Add(this.labelIV);
            this.Controls.Add(this.textBoxIV);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.comboBoxCipher);
            this.Name = "Form1";
            this.Text = "Generate Key and IV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCipher;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBoxIV;
        private System.Windows.Forms.Label labelIV;
        private System.Windows.Forms.Button buttonEnc;
        private System.Windows.Forms.TextBox textBoxPlain;
        private System.Windows.Forms.Label labelPlainText;
        private System.Windows.Forms.Label labelPlainTextASCII;
        private System.Windows.Forms.TextBox textBoxPlainHex;
        private System.Windows.Forms.Label labelPlainTextHEX;
        private System.Windows.Forms.Button buttonDec;
        private System.Windows.Forms.TextBox textBoxCipherHex;
        private System.Windows.Forms.TextBox textBoxCipher;
        private System.Windows.Forms.Label labelCipherText;
        private System.Windows.Forms.Label labelCipherASCII;
        private System.Windows.Forms.Label labelCipherHEX;
        private System.Windows.Forms.Button buttonEncTime;
        private System.Windows.Forms.Label labelEncTime;
        private System.Windows.Forms.Button buttonDecTime;
        private System.Windows.Forms.Label labelDecTime;
    }
}

