using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CdKeyGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] key = new string[] { string.Empty, "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        string[] id = new string[] { string.Empty, "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        string idR, keyR, keyRX;
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void create_button_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 4; i++)
            {
                keyRX = keyRX + Key_c(key) + "-";
                keyR = "";
            }
            keyRX = keyRX.Remove(19);
            Id_textBox.Text = Id_c(id);
            Key_textBox.Text = keyRX;
            idR = "";
            keyRX = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private string Id_c(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int x = rnd.Next(1, arr.Length);
                idR = idR + arr[x];
                if (idR.Length == 8)
                {
                    break;
                }
            }
            return idR;
        }

        private string Key_c(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int x = rnd.Next(1, arr.Length);
                keyR = keyR + arr[x];
                if (keyR.Length == 4)
                {
                 
                    break;
                    
                }
            }
            return keyR;
        }

    }
}
