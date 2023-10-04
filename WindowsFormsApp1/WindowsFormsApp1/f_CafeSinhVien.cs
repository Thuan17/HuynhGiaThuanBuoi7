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
    public partial class f_CafeSinhVien : Form
    {
        public f_CafeSinhVien()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        List<ListProDucts> SanPham;

        public  void ThanhToan()
        {
            
            SanPham.Add(new ListProDucts(12));


        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string Name = txtTenKhach.Text;
            if (Name == null || Name.Equals(""))
            {
                MessageBox.Show("Tài Khoản Không Để Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
               { }
        }

        private void f_CafeSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Muốn Thoát Chương Trình ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }





        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            rdi_CFSua.Checked = false;  
            rdi_CFDa.Checked = false;   
            rdi_CFKem.Checked = false;
            rdi_CFSDa.Checked = false;

            rdoBanhMi.Checked = false;  
            rdoBanhMyCa.Checked = false;    
            rdoMyBo.Checked = false;
            rdoMyCay.Checked = false;   
            rdoMyTomTrung.Checked = false;
            txtTenKhach.Text=null;
            txtSoKhachHang = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
