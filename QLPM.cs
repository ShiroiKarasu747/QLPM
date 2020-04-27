using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanlyPhongMay.Class;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyPhongMay
{
    public partial class QLPM : Form
    {

        public QLPM()
        {
            InitializeComponent();
        }

        private void lịchThựcHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*QuanLyPhongMay.ChildForms.QuanLyLichThucHanh.frmLichThucHanh f = new QuanLyPhongMay.ChildForms.QuanLyLichThucHanh.frmLichThucHanh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();*/
            QuanLyPhongMay_newvers.ChildForms.QuanLyLichThucHanh.frmLichThucHanh f = new QuanLyPhongMay_newvers.ChildForms.QuanLyLichThucHanh.frmLichThucHanh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void QLPM_Load(object sender, EventArgs e)
        {
            Functions.connect();
        }

        private void máyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMayTinh frmMT = new frmMayTinh();
            frmMT.ShowDialog();
        }

        private void mnuPhongMay_Click(object sender, EventArgs e)
        {
            FrmPhongMay frm = new FrmPhongMay();
            frm.ShowDialog();
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            FrmLop frm = new FrmLop();
            frm.ShowDialog();
        }

        private void mnuCaHoc_Click(object sender, EventArgs e)
        {
            FrmCaHoc frm = new FrmCaHoc();
            frm.ShowDialog();
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhongMay_newvers.frmGiaoVien f = new QuanLyPhongMay_newvers.frmGiaoVien();
            f.Show();
            f.StartPosition = FormStartPosition.CenterScreen;
        }

        private void bànPhímToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanPhim frm = new frmBanPhim();
            frm.ShowDialog();
        }

        private void chipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChip frm = new frmChip();
            frm.ShowDialog();
        }

        private void chuộtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaChuot frm = new frmMaChuot();
            frm.ShowDialog();
        }

        private void mànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManHinh frm = new frmManHinh();
            frm.ShowDialog();
        }

        private void cơMànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoManHinh frm = new frmCoManHinh();
            frm.ShowDialog();
        }

        private void dungLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDungLuong frm = new frmDungLuong();
            frm.ShowDialog();
        }

        private void ổCứngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOCung frm = new frmOCung();
            frm.ShowDialog();
        }

        private void ổĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmODia frm = new frmODia();
            frm.ShowDialog();
        }

        private void ramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRam frm = new frmRam();
            frm.ShowDialog();
        }

        private void tốcĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTocDo frm = new frmTocDo();
            frm.ShowDialog();
        }

        private void máyTínhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTimKiemMayTinh frm = new frmTimKiemMayTinh();
            frm.ShowDialog();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhongMay_newvers.frmSinhVien f = new QuanLyPhongMay_newvers.frmSinhVien();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void tỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhongMay_newvers.frmTinh f = new QuanLyPhongMay_newvers.frmTinh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void củaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhongMay_newvers.frmInLichThucHanh f = new QuanLyPhongMay_newvers.frmInLichThucHanh();
            f.Show();
            f.StartPosition = FormStartPosition.CenterScreen;
        }

        private void chưaKếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhongMay_newvers.frmInLTHChuaKetThuc f = new QuanLyPhongMay_newvers.frmInLTHChuaKetThuc();
            f.Show();
            f.StartPosition = FormStartPosition.CenterScreen;
        }

        private void mônThựcHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhongMay_newvers.ChildForms.QuanLyLichThucHanh.frmMonThucHanh f = new QuanLyPhongMay_newvers.ChildForms.QuanLyLichThucHanh.frmMonThucHanh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void lịchThựcHànhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QuanLyPhongMay_newvers.ChildForms.TimKiem.frmTimKiemLichThucHanh f = new QuanLyPhongMay_newvers.ChildForms.TimKiem.frmTimKiemLichThucHanh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInDanhSach frm = new FrmInDanhSach();
            frm.ShowDialog();
        }
    }
}
