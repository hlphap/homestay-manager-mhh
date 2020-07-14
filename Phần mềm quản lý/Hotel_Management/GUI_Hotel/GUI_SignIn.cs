using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Hotel;
using DTO_Hotel;
namespace Hotel_Management
{
    public partial class GUI_SignIn : Form
    {
        BUS_SignIn busSignIn = new BUS_SignIn();
        private FrmMain frm = new FrmMain();
        private FormLoading frmload = new FormLoading();
        private string MaNV;
        public GUI_SignIn()
        {
            InitializeComponent();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            PageSignIn.SetPage(0);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            PageSignIn.SetPage(1);
        }
        
        private void KiemTraDangNhap()
        {
            if ((txtUsername.Text != "") && (txtPassword.Text != ""))
            {
                DTO_SignIn account = new DTO_SignIn(txtUsername.Text, txtPassword.Text);
               
                if ((busSignIn.SignIn(account) == "1"))
                {
                    string result = busSignIn.SelectAll(account.user);
                    MaNV = result;
                    frmload.Show();

                    time_Loading.Enabled = true;
                    time_Loading.Start();
                  
  
                }
                else
                {
                    MessageBox.Show("Sai Mat Khau, Nhap Lai");
                }
            }
            else
            {
                MessageBox.Show("Sai Mat Khau, Nhap Lai!!!");
            }
        }
       
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap();
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                KiemTraDangNhap();
            }
        }

        private void time_Loading_Tick(object sender, EventArgs e)
        {
            this.Hide();
            
            frm.Message = MaNV;
            frm.Show();
            frmload.Hide();
            time_Loading.Stop();
        }

        private void bunifuTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {

        }
    }
}
