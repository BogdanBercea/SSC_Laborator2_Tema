using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ssc_good_homework
{
    public partial class Form1 : Form
    {
        ConversionHandler myConverter = new ConversionHandler();
        SymmetricAlgorithm mySymmetricAlg;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Generate(string cipher)
        {
            switch (cipher)
            {
                case "DES":
                    mySymmetricAlg = DES.Create();
                    break;
                case "3DES":
                    mySymmetricAlg = TripleDES.Create();
                    break;
                case "Rijndael":
                    mySymmetricAlg = Rijndael.Create();
                    break;
            }

            mySymmetricAlg.GenerateIV();
            mySymmetricAlg.GenerateKey();
        }

        public byte[] Encrypt(byte[] mess, byte[] key, byte[] iv)
        {
            mySymmetricAlg.Key = key;
            mySymmetricAlg.IV = iv;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, mySymmetricAlg.CreateEncryptor(),
                CryptoStreamMode.Write);

            cs.Write(mess, 0, mess.Length);
            cs.Close();

            return ms.ToArray();
        }

        public byte[] Decrypt(byte[] mess, byte[] key, byte[] iv)
        {

            byte[] plainText = new byte[mess.Length];

            mySymmetricAlg.Key = key;
            mySymmetricAlg.IV = iv;

            MemoryStream ms = new MemoryStream(mess);
            CryptoStream cs = new CryptoStream(ms, mySymmetricAlg.CreateDecryptor(),
                CryptoStreamMode.Read);

            cs.Read(plainText, 0, mess.Length);
            cs.Close();

            return plainText;
        }

        private void buttonEnc_Click(object sender, EventArgs e)
        {
            byte[] cipherText = Encrypt(myConverter.StringToByteArray(textBoxPlain.Text),
                myConverter.HexStringToByteArray(textBoxKey.Text),
                myConverter.HexStringToByteArray(textBoxIV.Text));

            textBoxCipher.Text = myConverter.ByteArrayToString(cipherText);
            textBoxCipherHex.Text = myConverter.ByteArrayToHexString(cipherText);

            myConverter.ByteArrayToHexString(myConverter.StringToByteArray(textBoxPlain.Text));
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            byte[] plainText = Decrypt(myConverter.HexStringToByteArray(textBoxCipherHex.Text),
                myConverter.HexStringToByteArray(textBoxKey.Text),
                myConverter.HexStringToByteArray(textBoxIV.Text));

            textBoxPlain.Text = myConverter.ByteArrayToString(plainText);
            textBoxPlainHex.Text = myConverter.ByteArrayToHexString(plainText);
        }

        private void buttonEncTime_Click(object sender, EventArgs e)
        {
            mySymmetricAlg.GenerateIV();
            mySymmetricAlg.GenerateKey();

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms,
                mySymmetricAlg.CreateEncryptor(),
                CryptoStreamMode.Write);

            byte[] mess_block = new byte[8];
            long start_time = DateTime.Now.Ticks;
            int count = 10000000;

            for (int i = 0; i < count; i++)
            {
                cs.Write(mess_block, 0, mess_block.Length);
            }

            cs.Close();

            double operation_time = (DateTime.Now.Ticks - start_time);
            operation_time = operation_time / (10 * count);

            labelEncTime.Text = "Time for encryption of a message block: " +
                operation_time.ToString() + " us";
        }

        private void buttonDecTime_Click(object sender, EventArgs e)
        {
            mySymmetricAlg.GenerateIV();
            mySymmetricAlg.GenerateKey();

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms,
                mySymmetricAlg.CreateDecryptor(),
                CryptoStreamMode.Read);

            byte[] mess_block = new byte[8];
            long start_time = DateTime.Now.Ticks;
            int count = 10000000;

            for (int i = 0; i < count; i++)
            {
                cs.Read(mess_block, 0, mess_block.Length);
            }

            cs.Close();

            double operation_time = (DateTime.Now.Ticks - start_time);
            operation_time = operation_time / (10 * count);

            labelDecTime.Text = "Time for encryption of a message block: " +
                operation_time.ToString() + " us";
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            Generate(comboBoxCipher.Text);
            
            textBoxKey.Text = myConverter.ByteArrayToHexString(mySymmetricAlg.Key);
            textBoxIV.Text = myConverter.ByteArrayToHexString(mySymmetricAlg.IV);
        }
    }
}
