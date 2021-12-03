using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CRC32.Checked = true;
            
        }
        private void fileOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileOpenpath = openFileDialog.FileName;
                    textBox_fileOpen.Text = fileOpenpath;
                }
            }
        }

        private void fileOUT_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileOUTpath = saveFileDialog.FileName;
                textBox_fileOUT.Text = fileOUTpath;
            }
        }
        private void button_Clean_Click(object sender, EventArgs e)
        {
            textBox_fileOpen.Text = "";
            textBox_fileOUT.Text = "";
            textBox_fileOpen.Focus();
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {

            byte[] inArr = File.ReadAllBytes(textBox_fileOpen.Text); 
            byte[] arr = myEncoding(inArr); 

            FileInfo fileOpen = new FileInfo(textBox_fileOpen.Text);
            long size = fileOpen.Length;
            labelFileOpen.Text = "Вхідний файл: " + size.ToString() + " байт";

            mySaveToFileOUT(arr, textBox_fileOUT.Text);
            FileInfo fileOUT = new FileInfo(textBox_fileOUT.Text);
            long size1 = fileOUT.Length;
            labelFileOUT.Text = "Вхідний файл: " + size1.ToString() + " байт";
            MessageBox.Show("У файл записано число (контрольна сума вихідного файлу):\n" + BitConverter.ToString(arr), Name = "Результат"); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

        private byte[] myEncoding(byte[] inArr)
        {
            byte[] result = { 0 };
          
            if (CRC32.Checked == true)
            {
                uint a = Crc.Crc32(inArr);
                return BitConverter.GetBytes(a);
            }
            if (HashAlgorithm.Checked == true)
            {
                HashAlgorithm sha = KeyedHashAlgorithm.Create();
                return sha.ComputeHash(inArr);
            }
            if (RIPEMD160.Checked == true)
            {
                HashAlgorithm sha = System.Security.Cryptography.RIPEMD160.Create();
                return sha.ComputeHash(inArr);
            }
            if (MD5.Checked == true)
            {
                HashAlgorithm sha = System.Security.Cryptography.MD5.Create();
                return sha.ComputeHash(inArr);
            }
            if (SHA_1.Checked == true)
            {
                HashAlgorithm sha = SHA1.Create();
                return sha.ComputeHash(inArr);
            }
            if (SHA_256.Checked == true)
            {
                HashAlgorithm sha = SHA256.Create();
                return sha.ComputeHash(inArr);
            }
            if (SHA_384.Checked == true)
            {
                HashAlgorithm sha = SHA384.Create();
                return sha.ComputeHash(inArr);
            }
            if (SHA_512.Checked == true)
            {
                HashAlgorithm sha = SHA512.Create();
                return sha.ComputeHash(inArr);
            }

            return result;
        }
        private void mySaveToFileOUT(byte[] arrCipher, string fileOUTpath)
        {
            using (FileStream fs = File.Create(fileOUTpath))
            {
                fs.Write(arrCipher, 0, arrCipher.Length);
                fs.Close();
            }
        }
        private void Author_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 Author = new Form2();
            Author.Show();
        }
        private void Cipher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 Cipher = new Form3();
            Cipher.Show();
        }
    }
}
