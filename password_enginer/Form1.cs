using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace password_enginer
{
    public partial class mian_form : Form
    {
        string row_hashed = "";
        string row_data = "";
        public mian_form()
        {
            InitializeComponent();
            string path = Directory.GetCurrentDirectory();
            save_path.Text = path + "\\output.txt";
        }


        private void mouse_collect(object sender, MouseEventArgs e)
        {
            mouse_x.Text = Convert.ToString(e.X);
            mouse_y.Text = Convert.ToString(e.Y);
            row_data += Convert.ToString(e.X, 2).PadLeft(9, '0') + Convert.ToString(e.Y, 2).PadLeft(9, '0');
            row_data += Convert.ToString(e.X, 2).PadLeft(9, '0') + Convert.ToString(e.Y, 2).PadLeft(9, '0');
            if (method_options.Text == "Von Neumann extractor")
            {
                for(int i=0; i<18; i+=2)
                {
                    if(row_data[i] != row_data[i + 1])
                    {
                        row_hashed += row_data[i].ToString() + row_data[i + 1].ToString();
                    }
                }
                row_data = "";
            }
            else if (method_options.Text == "SHA-256" && row_data.Length >= 512)
            {
                byte[] byteArray = Encoding.Default.GetBytes(row_data);
                for (int i = 0; i < byteArray.Length; i++)
                {
                    byteArray[i] -= 48;
                }
                using (SHA256 mySHA256 = SHA256.Create()) {
                    byte[] hashValue = mySHA256.ComputeHash(byteArray);
                    for (int i = 0; i < hashValue.Length; i++)
                    {
                        row_hashed += Convert.ToString(((int)hashValue[i]), 2).PadLeft(8, '0');
                    }
                }
                row_data = "";
            }
            else if (method_options.Text == "SHA-512" && row_data.Length >= 1024)
            {
                byte[] byteArray = Encoding.Default.GetBytes(row_data);
                for (int i = 0; i < byteArray.Length; i++)
                {
                    byteArray[i] -= 48;
                }
                using (SHA512 mySHA512 = SHA512.Create()) {
                    byte[] hashValue = mySHA512.ComputeHash(byteArray);
                    for (int i = 0; i < hashValue.Length; i++)
                    {
                        row_hashed += Convert.ToString(((int)hashValue[i]), 2).PadLeft(8, '0');
                    }
                }
                row_data = "";
            }
            else if (method_options.Text == "MD5" && row_data.Length >= 256)
            {
                byte[] byteArray = Encoding.Default.GetBytes(row_data);
                for (int i = 0; i < byteArray.Length; i++)
                {
                    byteArray[i] -= 48;
                }
                using (MD5 myMD5 = MD5.Create()) {
                    byte[] hashValue = myMD5.ComputeHash(byteArray);
                    for (int i = 0; i < hashValue.Length; i++)
                    {
                        row_hashed += Convert.ToString(((int)hashValue[i]), 2).PadLeft(8, '0');
                    }
                    row_data = "";
                }
            }
            row_hash_count.Text = "已產出亂數：" + Convert.ToString(row_hashed.Length);
        }

        private void Save_append(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = save_path.Text;
            saveFileDialog.ShowDialog();
            File.WriteAllText(saveFileDialog.FileName, row_hashed, Encoding.ASCII);
           
        }
    }
}
