using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyPhongMay
{
    public partial class frmMayTinh : Form
    {
        int doi = 0;
        DataTable tbMT = new DataTable();
        public frmMayTinh()
        {
            InitializeComponent();
        }

        private void Load_comboBox()
        {
            cboMPM.DataSource = Functions.getdatatotable("SELECT MaPM from tblPhongMay");
            cboMPM.ValueMember = "MaPM";
            cboMPM.DisplayMember = "MaPM";
            cboMPM.SelectedIndex = -1;
            cboMOC.DataSource = Functions.getdatatotable("SELECT MaOCung from tblOCUng");
            cboMOC.ValueMember = "MaOCung";
            cboMOC.DisplayMember = "MaOCung";
            cboMOC.SelectedIndex = -1;
            cboMDL.DataSource = Functions.getdatatotable("SELECT MaDungLuong from tblDungLuong");
            cboMDL.ValueMember = "MaDungLuong";
            cboMDL.DisplayMember = "MaDungLuong";
            cboMDL.SelectedIndex = -1;
            cboMaChip.DataSource = Functions.getdatatotable("SELECT MaChip from tblChip");
            cboMaChip.ValueMember = "MaChip";
            cboMaChip.DisplayMember = "MaChip";
            cboMaChip.SelectedIndex = -1;
            cboMaRAM.DataSource = Functions.getdatatotable("SELECT MaRAM from tblRAM");
            cboMaRAM.ValueMember = "MaRAM";
            cboMaRAM.DisplayMember = "MaRAM";
            cboMaRAM.SelectedIndex = -1;
            cboMTD.DataSource = Functions.getdatatotable("SELECT MaTocDo from tblTocDo");
            cboMTD.ValueMember = "MaTocDo";
            cboMTD.DisplayMember = "MaTocDo";
            cboMTD.SelectedIndex = -1;
            cboMMH.DataSource = Functions.getdatatotable("SELECT MaManHinh from tblManHinh");
            cboMMH.ValueMember = "MaManHinh";
            cboMMH.DisplayMember = "MaManHinh";
            cboMMH.SelectedIndex = -1;
            cboMCMH.DataSource = Functions.getdatatotable("SELECT MaCoMH from tblCoManHinh");
            cboMCMH.ValueMember = "MaCoMH";
            cboMCMH.DisplayMember = "MaCoMH";
            cboMCMH.SelectedIndex = -1;
            cboMaChuot.DataSource = Functions.getdatatotable("SELECT MaChuot from tblMaChuot");
            cboMaChuot.ValueMember = "MaChuot";
            cboMaChuot.DisplayMember = "MaChuot";
            cboMaChuot.SelectedIndex = -1;
            cboMBP.DataSource = Functions.getdatatotable("SELECT MaBanPhim from tblMaBanPhim");
            cboMBP.ValueMember = "MaBanPhim";
            cboMBP.DisplayMember = "MaBanPhim";
            cboMBP.SelectedIndex = -1;
            cboMOD.DataSource = Functions.getdatatotable("SELECT MaODia from tblMaODia");
            cboMOD.ValueMember = "MaODia";
            cboMOD.DisplayMember = "MaODia";
            cboMOD.SelectedIndex = -1;

        }

        private void loaddata()
        {
            string sql;
            sql = "select * from tblMayTinh";
            tbMT = Functions.getdatatotable(sql);
            dgvMT.DataSource = tbMT;
            dgvMT.AllowUserToAddRows = false;
            dgvMT.EditMode = DataGridViewEditMode.EditProgrammatically;
            txtMaMay.Enabled = false;
            txtTenMay.Enabled = false;
            cboMPM.Enabled = false;
            cboMOC.Enabled = false;
            cboMDL.Enabled = false;
            cboMaChip.Enabled = false;
            cboMaRAM.Enabled = false;
            cboMTD.Enabled = false;
            cboMMH.Enabled = false;
            cboMCMH.Enabled = false;
            cboMaChuot.Enabled = false;
            cboMBP.Enabled = false;
            cboMOD.Enabled = false;
            txtNote.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            Load_comboBox();
        }

        private void frmMayTinh_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dgvMT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            doi = 0;
            int i = dgvMT.CurrentRow.Index;
            txtMaMay.Text = dgvMT.Rows[i].Cells[0].Value.ToString();
            txtTenMay.Text = dgvMT.Rows[i].Cells[1].Value.ToString();
            cboMPM.SelectedValue = dgvMT.Rows[i].Cells[2].Value.ToString();
            cboMOC.SelectedValue = dgvMT.Rows[i].Cells[3].Value.ToString();
            cboMDL.SelectedValue = dgvMT.Rows[i].Cells[4].Value.ToString();
            cboMaChip.SelectedValue = dgvMT.Rows[i].Cells[5].Value.ToString();
            cboMaRAM.SelectedValue = dgvMT.Rows[i].Cells[6].Value.ToString();
            cboMTD.SelectedValue = dgvMT.Rows[i].Cells[7].Value.ToString();
            cboMMH.SelectedValue = dgvMT.Rows[i].Cells[8].Value.ToString();
            cboMCMH.SelectedValue = dgvMT.Rows[i].Cells[9].Value.ToString();
            cboMaChuot.SelectedValue = dgvMT.Rows[i].Cells[10].Value.ToString();
            cboMBP.SelectedValue = dgvMT.Rows[i].Cells[11].Value.ToString();
            cboMOD.SelectedValue = dgvMT.Rows[i].Cells[12].Value.ToString();
            txtNote.Text = dgvMT.Rows[i].Cells[13].Value.ToString();
            txtMaMay.Enabled = false;
            txtTenMay.Enabled = true;
            cboMPM.Enabled = true;
            cboMOC.Enabled = true;
            cboMDL.Enabled = true;
            cboMaChip.Enabled = true;
            cboMaRAM.Enabled = true;
            cboMTD.Enabled = true;
            cboMMH.Enabled = true;
            cboMCMH.Enabled = true;
            cboMaChuot.Enabled = true;
            cboMBP.Enabled = true;
            cboMOD.Enabled = true;
            txtNote.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaMay.Enabled = true;
            txtTenMay.Enabled = true;
            cboMPM.Enabled = true;
            cboMOC.Enabled = true;
            cboMDL.Enabled = true;
            cboMaChip.Enabled = true;
            cboMaRAM.Enabled = true;
            cboMTD.Enabled = true;
            cboMMH.Enabled = true;
            cboMCMH.Enabled = true;
            cboMaChuot.Enabled = true;
            cboMBP.Enabled = true;
            cboMOD.Enabled = true;
            txtNote.Enabled = true;
            txtMaMay.Text = "";
            txtTenMay.Text = "";
            cboMPM.SelectedValue = "";
            cboMOC.SelectedValue = "";
            cboMDL.SelectedValue = "";
            cboMaChip.SelectedValue = "";
            cboMaRAM.SelectedValue = "";
            cboMTD.SelectedValue = "";
            cboMMH.SelectedValue = "";
            cboMCMH.SelectedValue = "";
            cboMaChuot.SelectedValue = "";
            cboMBP.SelectedValue = "";
            cboMOD.SelectedValue = "";
            txtNote.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            doi = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql="update tblMayTinh set TenMay='" + txtTenMay.Text + "', MaPM='" + cboMPM.SelectedValue + "', MaOCung='" 
                + cboMOC.SelectedValue + "', MaDungLuong='" + cboMDL.SelectedValue + "', MaChip='" + cboMaChip.SelectedValue + "', MaRAM='" 
                + cboMaRAM.SelectedValue + "', MaTocDo='" + cboMTD.SelectedValue + "', MaManHinh='" + cboMMH.SelectedValue + "', MaCoMH='" 
                + cboMCMH.SelectedValue + "', MaChuot='" + cboMaChuot.SelectedValue + "', MaBanPhim='" + cboMBP.SelectedValue + "', MaODia='" 
                + cboMOD.SelectedValue + "', GhiChu='"+txtNote.Text+"'where MaMay='" +txtMaMay.Text+"'";
            Functions.RunSQL(sql);
            loaddata();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaMay.Text == "" || cboMPM.Text == "" || cboMOC.Text == "" || cboMDL.Text == "" || cboMaChip.Text == "" || cboMaRAM.Text == "" || cboMTD.Text == ""
                || cboMMH.Text == "" || cboMCMH.Text == "" || cboMaChuot.Text == "" || cboMBP.Text == "" || cboMOD.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ các mã");
                return;
            }
            string sql = "select MaMay from tblMayTinh where MaMay='"+txtMaMay.Text+"'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã máy này đã tồn tại");
                txtMaMay.Focus();
                return;
            }
            sql = "insert into tblMayTinh values ('" + txtMaMay.Text + "', '" + txtTenMay.Text + "', '" + cboMPM.SelectedValue + "', '" + cboMOC.SelectedValue + "', '" 
                + cboMDL.SelectedValue + "', '" + cboMaChip.SelectedValue + "', '" + cboMaRAM.SelectedValue + "', '" + cboMTD.SelectedValue + "', '" + cboMMH.SelectedValue + "', '" 
                + cboMCMH.SelectedValue + "', '" + cboMaChuot.SelectedValue + "', '" + cboMBP.SelectedValue + "', '" + cboMOD.SelectedValue + "', '"+txtNote.Text+"')";
            Functions.RunSQL(sql);
            string sql2 = "exec CapnhatSomay '" + cboMPM.SelectedValue + "'";
            doi = 0;
            Functions.RunSQL(sql2);
            loaddata();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            doi = 0;
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            txtMaMay.Text = "";
            txtTenMay.Text = "";
            cboMPM.SelectedValue = "";
            cboMOC.SelectedValue = "";
            cboMDL.SelectedValue = "";
            cboMaChip.SelectedValue = "";
            cboMaRAM.SelectedValue = "";
            cboMTD.SelectedValue = "";
            cboMMH.SelectedValue = "";
            cboMCMH.SelectedValue = "";
            cboMaChuot.SelectedValue = "";
            cboMBP.SelectedValue = "";
            cboMOD.SelectedValue = "";
            txtNote.Text = "";
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblMayTinh where MaMay='" + txtMaMay.Text + "'";
            Functions.RunSQL(sql);
            loaddata();
        }

        /*private void cboMPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                    DataTable tbl = Functions.getdatatotable("SELECT * FROM tblMayTinh WHERE MaPM = N'" + cboMPM.SelectedValue + "'");
                    dgvMT.DataSource = tbl;
                    loaddata();
            }
            catch { }
        }*/

        private void cboMPM_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (doi==1)
            {
                DataTable tbl = Functions.getdatatotable("SELECT * FROM tblMayTinh WHERE MaPM = N'" + cboMPM.SelectedValue + "'");
                dgvMT.DataSource = tbl;
                //loaddata();
            }
        }
    }
}
