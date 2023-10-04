using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Khach> khachhang;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            khachhang = new List<Khach>(); 
            khachhang.Add(new Khach("thuan"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Khach kh in khachhang)
            {
                if (button1.Text == kh.getName())
                {
                    label1.Text = kh.getName();
                }
            
            }
        }
    }
}
