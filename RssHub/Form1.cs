using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = text_input.Text.ToString();
            string old_link = "https://rsshub.app";
            string new_link = "1.1.1.1:1200";
            data = data.Replace(old_link, new_link);
            text_output.Text = data;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data2 = text_input2.Text.ToString();
            //string old_link = "https://rsshub.app";   举例: https://rsshub.app/
            string new_link = "https://rsshub.app/";
            data2 = data2.Insert(0, new_link);
            text_output2.Text = data2;
        }
    }
}
