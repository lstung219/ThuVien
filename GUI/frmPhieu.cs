﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPhieu : Form
    {
        public frmPhieu()
        {
            InitializeComponent();
        }

        private void lbListSachMuon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_PhieuMuon_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemPhieuMuon_Click(object sender, EventArgs e)
        {
            dgvPhieuMuon.AllowUserToAddRows = false;
            if (txtSearchPM.Text == "" || (rdMaDG_PhieuMuon.Checked == false && rdMaPhieuMuon.Checked == false))
            {
                MessageBox.Show("Vui lòng chọn và điền đầy đủ thông tin !!!");
            }
            else
            {

                BLL_Phieu busPhieu = new BLL_Phieu();
                string maDocGia;
                string maPhieuMuon;
                if (rdMaDG_PhieuMuon.Checked)
                {
                    maDocGia = txtSearchPM.Text;
                    dgvPhieuMuon.DataSource = busPhieu.SearchPhieuMuonTheoMaDocGia(maDocGia);
                    dgvPhieuMuon.ReadOnly = true;
                }
                else if (rdMaPhieuMuon.Checked)
                {
                    maPhieuMuon = txtSearchPM.Text;
                    dgvPhieuMuon.DataSource = busPhieu.SearchPhieuMuonTheoMaPhieuMuon(maPhieuMuon);
                    dgvPhieuMuon.ReadOnly = true;
                }

                if (dgvPhieuMuon.RowCount > 0)
                {
                    btnChinhSua_CTPM.Visible = false;
                    btnLuuCTPM.Visible = false;
                    btnHuy_PhieuMuon.Visible = false;

                    btnXemChiTiet_PhieuMuon.Visible = true;
                    btnXoaPhieuMuon.Visible = true;
                }
                if (dgvPhieuMuon.RowCount == 0)
                    MessageBox.Show("Không tìm thấy thông tin");

            }
        }

        private void btnXemTatcaPhieuMuon_Click(object sender, EventArgs e)
        {
            BLL_Phieu busPhieu = new BLL_Phieu();
            dgvPhieuMuon.DataSource = busPhieu.XemTatCaPhieuMuon();
            dgvPhieuMuon.ReadOnly = true;

            dgvPhieuMuon.Columns[0].HeaderText = "Mã Phiếu Mượn";
            dgvPhieuMuon.Columns[1].HeaderText = "Ngày Lập";
            dgvPhieuMuon.Columns[2].HeaderText = "Mã Độc Giả";
            dgvPhieuMuon.Columns[3].HeaderText = "Mã Quản Thư";


            btnXemChiTiet_PhieuMuon.Visible = true;
            btnXoaPhieuMuon.Visible = true;

            btnChinhSua_CTPM.Visible = false;
            btnLuuCTPM.Visible = false;
            btnHuy_PhieuMuon.Visible = false;
        }

        private void btnXemChiTiet_PhieuMuon_Click(object sender, EventArgs e)
        {
            btnChinhSua_CTPM.Visible = true;
            btnLuuCTPM.Visible = true;
            btnHuy_PhieuMuon.Visible = true;

            btnXemChiTiet_PhieuMuon.Visible = false;
            btnXoaPhieuMuon.Visible = false;

            if (dgvPhieuMuon.RowCount < 1)
            {
                return;
            }
            BLL_Phieu busPhieu = new BLL_Phieu();
            string maPhieuMuon = dgvPhieuMuon[0, dgvPhieuMuon.CurrentRow.Index].Value.ToString();
            dgvPhieuMuon.DataSource = null;
            dgvPhieuMuon.DataSource = busPhieu.XemChiTietPhieuMuon(maPhieuMuon);
            dgvPhieuMuon.ReadOnly = true;
            dgvPhieuMuon.Columns[0].HeaderText = "Chi Tiết Phiếu Mượn";
            dgvPhieuMuon.Columns[1].HeaderText = "Mã Tài Liệu";
            dgvPhieuMuon.Columns[2].HeaderText = "Mã Phiếu Mượn";
            btnHuy_PhieuMuon.Text = "Hủy";
        }

        private void btnHuy_PhieuMuon_Click(object sender, EventArgs e)
        {
            btnXemTatcaPhieuMuon_Click(sender, e);
        }

        private void btnChinhSua_CTPM_Click(object sender, EventArgs e)
        {
            dgvPhieuMuon.ReadOnly = false;
            dgvPhieuMuon.Columns[0].ReadOnly = true;
        }

        private void btnLuuCTPM_Click(object sender, EventArgs e)
        {
            //btnHuy_PhieuMuon.Text = "Thoát";
            //string maCTPM = dgvPhieuMuon[0, dgvPhieuMuon.CurrentRow.Index].Value.ToString();
            //string maTaiLieu = dgvPhieuMuon[1, dgvPhieuMuon.CurrentRow.Index].Value.ToString();
            //string maTaiLieuCu = txtCapNhatCTPM.Text;
            //string maPhieuMuon = dgvPhieuMuon[2, dgvPhieuMuon.CurrentRow.Index].Value.ToString();

            //DTO_PhieuMuon x = new DTO_PhieuMuon(maCTPM, maTaiLieu, maTaiLieuCu, maPhieuMuon);
            //BLL_Phieu p = new BLL_Phieu();
            //p.UpdatePhieuMuon(x);
        }

        private void btnXoaPhieuMuon_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.RowCount < 1)
            {
                return;
            }
            BLL_Phieu busPhieu = new BLL_Phieu();
            string maPhieuMuon = dgvPhieuMuon[0, dgvPhieuMuon.CurrentRow.Index].Value.ToString();
            if (MessageBox.Show(string.Format("Xác nhận xóa Phiếu Mượn : {0}", maPhieuMuon), "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (busPhieu.XoaPhieuMuon(maPhieuMuon))
                {
                    MessageBox.Show("Xóa Phiếu Mượn Thành Công");
                    dgvPhieuMuon.DataSource = busPhieu.XemTatCaPhieuMuon();
                    dgvPhieuMuon.ReadOnly = true;
                }
                else
                    MessageBox.Show("Không Thể Xóa Phiếu Mượn Này !");
            }

        }

        private void cbxMaTLPM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddMTLVaoList_Click(object sender, EventArgs e)
        {
            string maDocGia = cbxMaDGPM.SelectedValue.ToString();
            BLL_Phieu p = new BLL_Phieu();
            for (int i = 0; i < Int32.Parse(lbListSachMuon.Items.Count.ToString()); i++)
            {
                string value = lbListSachMuon.Items[i].ToString().Trim();
                if (value == cbxMaTLPM.Text.ToString().Trim())
                {
                    MessageBox.Show("Tài Liệu Này Đã Có !!!");
                    return;
                }
            }
            if ((p.SoSachDangMuon(maDocGia) + lbListSachMuon.Items.Count) < 5)
            {
                    lbListSachMuon.Items.Add(cbxMaTLPM.Text);
                    lbListSachMuonHide.Items.Add(cbxMaTLPM.SelectedValue);
            }
            else MessageBox.Show("Đã quá số sách mượn tối đa");
        }

        private void btnXemTatCaPhieuTra_Click(object sender, EventArgs e)
        {
                BLL_Phieu busPhieu = new BLL_Phieu();
                dgvPhieuTra.DataSource = busPhieu.XemTatCaPhieuTra();
                dgvPhieuTra.ReadOnly = true;

                dgvPhieuTra.Columns[0].HeaderText = "Mã Phiếu Trả";
                dgvPhieuTra.Columns[1].HeaderText = "Ngày Lập Phiếu Trả";
                dgvPhieuTra.Columns[2].HeaderText = "Mã Độc Giả";
                dgvPhieuTra.Columns[3].HeaderText = "Mã Quản Thư";
            btnXemChiTietPhieuTra.Visible = true;
                btnXoaPhieuTra.Visible = true;

                btnChinhSua_PhieuTra.Visible = false;
                btnLuuPhieuTra.Visible = false;
                btnHuy_PhieuTra.Visible = false;
        }

        private void btnTimKiemPhieuTra_Click(object sender, EventArgs e)
        {
            if ((rdMaDG_PhieuTra.Checked == false && rdMaPhieuMuon_PhieuTraTK.Checked == false && rdMaPhieuTra.Checked == false) || (txtSearchPT.Text == ""))
            {
                MessageBox.Show("Vui lòng chọn điều kiện để tìm kiếm!!!");
            }
            else
            {
                BLL_Phieu p = new BLL_Phieu();
                if (rdMaDG_PhieuTra.Checked)
                {
                    dgvPhieuTra.DataSource = p.SearchPhieuTraTheoMaDocGia(txtSearchPT.Text);
                }
                if (rdMaPhieuMuon_PhieuTraTK.Checked)
                {
                    dgvPhieuTra.DataSource = p.SearchPhieuTraTheoMaPhieuMuon(txtSearchPT.Text);
                }
                if (rdMaPhieuTra.Checked)
                {
                    dgvPhieuTra.DataSource = p.SearchPhieuTraTheoMaPhieuTra(txtSearchPT.Text);
                }
                btnXemChiTietPhieuTra.Visible = true;
                btnXoaPhieuTra.Visible = true;

                btnChinhSua_PhieuTra.Visible = false;
                btnLuuPhieuTra.Visible = false;
                btnHuy_PhieuTra.Visible = false;
            }
        }

        private void btnXemChiTietPhieuTra_Click(object sender, EventArgs e)
        {
            btnXemChiTietPhieuTra.Visible = false;
            btnXoaPhieuTra.Visible = false;

            btnChinhSua_PhieuTra.Visible = true;
            btnLuuPhieuTra.Visible = true;
            btnHuy_PhieuTra.Visible = true;
            if (dgvPhieuTra.RowCount < 1)
            {
                return;
            }
            BLL_Phieu busPhieu = new BLL_Phieu();
            string maPhieuTra = dgvPhieuTra[0, dgvPhieuTra.CurrentRow.Index].Value.ToString();
            dgvPhieuTra.DataSource = null;
            dgvPhieuTra.DataSource = busPhieu.XemChiTietPhieuTra(maPhieuTra);
            dgvPhieuTra.ReadOnly = true;

            dgvPhieuTra.Columns[0].HeaderText = "Chi Tiết Phiểu Trả";
            dgvPhieuTra.Columns[1].HeaderText = "Mã Phiếu Trả";
            dgvPhieuTra.Columns[2].HeaderText = "Mã Phiếu Mượn";
            dgvPhieuTra.Columns[3].HeaderText = "Mã Tài Liệu";
            btnHuy_PhieuTra.Text = "Hủy";
        }
    }
}