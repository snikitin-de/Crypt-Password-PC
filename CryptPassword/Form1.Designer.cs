namespace CryptPassword
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodeword = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmPassword = new System.Windows.Forms.MaskedTextBox();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.btnSaveQR = new System.Windows.Forms.Button();
            this.btnLoadQR = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRecognizeQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codeword";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(72, 9);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(333, 20);
            this.txtSite.TabIndex = 2;
            this.txtSite.Validating += new System.ComponentModel.CancelEventHandler(this.txtSite_Validating);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.CausesValidation = false;
            this.btnEncrypt.Location = new System.Drawing.Point(15, 115);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(93, 28);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Site";
            // 
            // txtCodeword
            // 
            this.txtCodeword.Location = new System.Drawing.Point(72, 61);
            this.txtCodeword.Name = "txtCodeword";
            this.txtCodeword.Size = new System.Drawing.Size(333, 20);
            this.txtCodeword.TabIndex = 7;
            this.txtCodeword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodeword_Validating);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(72, 89);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(333, 20);
            this.txtResult.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Result";
            // 
            // txtmPassword
            // 
            this.txtmPassword.Location = new System.Drawing.Point(72, 35);
            this.txtmPassword.Name = "txtmPassword";
            this.txtmPassword.PasswordChar = '*';
            this.txtmPassword.Size = new System.Drawing.Size(333, 20);
            this.txtmPassword.TabIndex = 10;
            this.txtmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtmPassword_Validating);
            // 
            // picQR
            // 
            this.picQR.Location = new System.Drawing.Point(430, 9);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(186, 181);
            this.picQR.TabIndex = 11;
            this.picQR.TabStop = false;
            // 
            // btnSaveQR
            // 
            this.btnSaveQR.CausesValidation = false;
            this.btnSaveQR.Location = new System.Drawing.Point(114, 115);
            this.btnSaveQR.Name = "btnSaveQR";
            this.btnSaveQR.Size = new System.Drawing.Size(93, 28);
            this.btnSaveQR.TabIndex = 12;
            this.btnSaveQR.Text = "Save QR";
            this.btnSaveQR.UseVisualStyleBackColor = true;
            this.btnSaveQR.Click += new System.EventHandler(this.btnSaveQR_Click);
            // 
            // btnLoadQR
            // 
            this.btnLoadQR.CausesValidation = false;
            this.btnLoadQR.Location = new System.Drawing.Point(213, 115);
            this.btnLoadQR.Name = "btnLoadQR";
            this.btnLoadQR.Size = new System.Drawing.Size(93, 28);
            this.btnLoadQR.TabIndex = 13;
            this.btnLoadQR.Text = "Load QR";
            this.btnLoadQR.UseVisualStyleBackColor = true;
            this.btnLoadQR.Click += new System.EventHandler(this.btnLoadQR_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnRecognizeQR
            // 
            this.btnRecognizeQR.CausesValidation = false;
            this.btnRecognizeQR.Location = new System.Drawing.Point(312, 115);
            this.btnRecognizeQR.Name = "btnRecognizeQR";
            this.btnRecognizeQR.Size = new System.Drawing.Size(93, 28);
            this.btnRecognizeQR.TabIndex = 14;
            this.btnRecognizeQR.Text = "Recognize QR";
            this.btnRecognizeQR.UseVisualStyleBackColor = true;
            this.btnRecognizeQR.Click += new System.EventHandler(this.btnRecognizeQR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 198);
            this.Controls.Add(this.btnRecognizeQR);
            this.Controls.Add(this.btnLoadQR);
            this.Controls.Add(this.btnSaveQR);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.txtmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtCodeword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypt Password";
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodeword;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtmPassword;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Button btnSaveQR;
        private System.Windows.Forms.Button btnLoadQR;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnRecognizeQR;
    }
}

