using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Drawing;

namespace CryptPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtResult.Text = ReplaceSymbols(Hash());
            picQR.Image = CreateQR(txtResult.Text) as Image;
        }

        private void btnSaveQR_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); 
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp"; 
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                picQR.Image.Save(save.FileName);
            }
        }

        private void btnLoadQR_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog(); 
            if (load.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                picQR.ImageLocation = load.FileName;
            }
        }

        private void btnRecognizeQR_Click(object sender, EventArgs e)
        {
            txtResult.Text = RecognizeQR(picQR.Image as Bitmap);
        }

        private void txtSite_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSite.Text))
            {
                errorProvider1.SetError(txtSite, "Site not specified!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtSite, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtmPassword.Text))
            {
                errorProvider1.SetError(txtmPassword, "Password not specified!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtmPassword, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtCodeword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodeword.Text))
            {
                errorProvider1.SetError(txtCodeword, "Codeword not specified!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCodeword, String.Empty);
                e.Cancel = false;
            }
        }

        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string ReplaceSymbols(string s)
        {
            int i = 0;
            int search = 0;

            if (ValidateChildren())
            {
                foreach (char symbol in s.ToCharArray())
                {
                    if (!Char.IsDigit(symbol))
                    {
                        search = i;
                        break;
                    }
                    i++;
                }

                s = s.Remove(search, 1).Insert(search, s[search].ToString().ToUpper());

                i = 0;
                search = 0;

                foreach (char symbol in s.ToCharArray())
                {
                    if (Char.IsDigit(symbol))
                    {
                        search = i;
                        break;
                    }
                    i++;
                }

                s = s.Remove(search, 1).Insert(search, "%");
            }

            return s;
        }

        public string Hash()
        {
            string site = txtSite.Text;
            string pass = txtmPassword.Text;
            string codeword = txtCodeword.Text;
            string salt = "^&#%@~$*^";
            string str = salt + site + codeword + pass + salt;
            string resultStr = String.Empty;

            byte[] data = new UTF8Encoding().GetBytes(str);
            byte[] result;

            if (ValidateChildren())
            {
                SHA512 shaM = new SHA512Managed();
                result = shaM.ComputeHash(data);
                resultStr = ReverseString(BitConverter.ToString(result).ToLower().Replace("-", String.Empty));

                return resultStr.Substring(5, 25);
            }
            else return String.Empty;
        }

        public Bitmap CreateQR(string text)
        {
            string qrtext = text;
            QRCodeEncoder encoder = new QRCodeEncoder();
            return encoder.Encode(qrtext);
        }

        public string RecognizeQR(Bitmap bmp)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            return decoder.decode(new QRCodeBitmapImage(bmp));
        }
    }
}
