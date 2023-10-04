using System;
using System.Collections;
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
    public partial class fGiaiPhuongTrinh : Form
    {
        public fGiaiPhuongTrinh()
        {
            InitializeComponent();
        }
        List<TextBox> pList = new List<TextBox>();

        public List<TextBox> DSTextBox()
        {
            pList.Add(txt_a);
            pList.Add(txt_b);
            return pList;
        }

        private void btn_giai_Click(object sender, EventArgs e)
        {

        }
        public bool Enable(List<TextBox> pList)
        {
            foreach (TextBox item in pList)
            {
                if (item.Text.Length == 0)
                    return false;
            }
            return true;
        }

        private void radptb1_CheckedChanged(object sender, EventArgs e)
        {
            if (radptb2.Checked)
            {
                lblc.Enabled = true;
                txt_c.Enabled = true;
                pList.Add(txt_c);
            }
            else
            {
                lblc.Enabled = false;
                txt_c.Enabled = false;
                pList.Remove(txt_c);
            }
            reset();
        }
        void reset()
        {
            txt_a.Text = string.Empty;
            txt_b.Text = string.Empty;
            txt_c.Text = string.Empty;
            txt_kq.Text = string.Empty;
            txt_a.Focus();
        }
        private void fGiaiPhuongTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Thoát", "Bạn có muốn thoát chương trình?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txt_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_a_TextChanged(object sender, EventArgs e)
        {
            btn_giai.Enabled = Enable(DSTextBox());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        // public string Giai_ptb1(float a, float b)
        //{
        //    //a = float.Parse(txt_a.Text);
        //    //b = float.Parse(txt_b.Text);
        //    //string s = string.Empty;
        //    if (a == 0)
        //        return "phương trình vô nghiệm";
        //    else if (b == 0)
        //        return "phương trình có vô số nghiệm";
        //    else
        //        return Math.Round((-b / a), 2);
        //    //{
        //    //     float kq = -b / a;
        //    //     txt_kq.Text = kq.ToString();
        //    //     txt_kq.Text = "Phương trình có nghiệm duy nhất" + kq;
        //    //}
        //    //btn_giai.Enabled = true;
        //    //btn_thoat.Enabled = false;


        //}
    }
}
