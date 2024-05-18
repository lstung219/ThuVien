using BLL;
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
        private BLL_Phieu p;
        public frmPhieu()
        {
            InitializeComponent();
            BLL_Phieu p = new BLL_Phieu();
            lbDanhSachSachTraHide.Hide();
            lbListSachMuonHide.Hide();
            cbxMaPMCuaPT.DataSource = p.LoadMaPhieuMuon();
            cbxMaPMCuaPT.DisplayMember = "MaPhieuMuon";
            cbxMaPMCuaPT.ValueMember = "MaPhieuMuon";
            LoadDataFromFormDanhSachDocGia();
            cbxMaTLPM.DataSource = p.LayDanhSachSach();
            cbxMaTLPM.DisplayMember = "TenSach";
            cbxMaTLPM.ValueMember = "MaSach";
        }
        public string maDG;
        private void LoadDataFromFormDanhSachDocGia()
        {
            FormDanhSachDocGia formDanhSachDocGia = (FormDanhSachDocGia)Application.OpenForms["FormDanhSachDocGia"];
            if (formDanhSachDocGia != null)
            {
                string loaiPhieu = formDanhSachDocGia.LoaiPhieu;
                if (loaiPhieu == "PhieuMuon")
                {
                    maDG = formDanhSachDocGia.MaDG;
                    string tenDG = formDanhSachDocGia.TenDG;
                    cbxMaDGPM.Text = tenDG;
                    cbxMaDGPM.SelectedValue = maDG;
                    lbMaDocGia.Text = maDG;
                    tbcQuanLiPhieu.SelectedTab = tbcQuanLiPhieu.TabPages[0];
                    tbcPhieuMuon.SelectedTab = tbcPhieuMuon.TabPages[1];
                }
                if (loaiPhieu == "PhieuTra")
                {
                    BLL_Phieu ph = new BLL_Phieu();
                    string maDG = formDanhSachDocGia.MaDG;
                    txtSearchPT.Text = maDG;
                    cbxMaPMCuaPT.DataSource = ph.LayMaPhieuMuonTheoMaDG(maDG);
                    BLL_Phieu phieu = new BLL_Phieu();
                    string MPM = cbxMaPMCuaPT.Text;
                    tbcQuanLiPhieu.SelectedTab = tbcQuanLiPhieu.TabPages[1];
                    tbcPhieuTra.SelectedTab = tbcPhieuTra.TabPages[1];
                    cbxSachPT.DataSource = phieu.LayDanhSachMaTaiLieuCuaPhieuMuon(MPM);
                    cbxSachPT.DisplayMember = "TenSach";
                    cbxSachPT.ValueMember = "MaSach";

                }

            }
        }
        private void lbListSachMuon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_PhieuMuon_Click(object sender, EventArgs e)
        {
            if (lbListSachMuon.Items.Count > 0)
            {
                string madocgia = /*cbxMaDGPM.SelectedValue.ToString().Trim();*/ maDG;
                string masach = lbListSachMuonHide.Items[0].ToString().Trim();
                string maQTHienTai = "QT001";
                BLL_Phieu mpm = new BLL_Phieu();
                string maphieumuon = mpm.LayMaPhieuMuonTiepTheo().Trim();
                string mactpm = mpm.LayMaChiTietPhieuMuonTiepTheo().Trim();

                BLL_Phieu bllPhieu = new BLL_Phieu();
                //DTO_PhieuMuon DTO = new DTO_PhieuMuon(maQTHienTai.Trim(),madocgia, masach, maphieumuon, mactpm);

                if (bllPhieu.ThemPhieuMuon(maQTHienTai, madocgia, masach, maphieumuon, mactpm) == 1)
                {
                    for (int i = 0; i < Int32.Parse(lbListSachMuonHide.Items.Count.ToString()); i++)
                    {
                        string maSach = lbListSachMuonHide.Items[i].ToString().Trim();
                        BLL_Phieu bllPhieuCT = new BLL_Phieu();
                        //DTO_PhieuMuon DTOCT = new DTO_PhieuMuon(maQTHienTai, madocgia, masach, maphieumuon, mactpm);
                        bllPhieu.ThemChiTietPhieuMuon(mactpm, maSach, maphieumuon);
                    }
                    MessageBox.Show("Lập Phiếu Mượn Thành Công !!!");

                    lbListSachMuon.Items.Clear();
                    lbListSachMuonHide.Items.Clear();
                    BLL_Phieu p = new BLL_Phieu();
                    cbxMaPMCuaPT.DataSource = p.LoadMaPhieuMuon();
                    cbxMaPMCuaPT.DisplayMember = "MaPhieuMuon";
                    cbxMaPMCuaPT.ValueMember = "MaPhieuMuon";
                }
                else
                {
                    lbListSachMuon.Items.Clear();
                    lbListSachMuonHide.Items.Clear();
                    MessageBox.Show("Độc giả không được sử dụng dịch vụ nữa :(");
                }
            }
            else MessageBox.Show("Vui lòng chọn tài liệu mượn");

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
            btnHuy_PhieuMuon.Visible = false;
        }

        private void btnXemChiTiet_PhieuMuon_Click(object sender, EventArgs e)
        {
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
            dgvPhieuMuon.Columns[1].HeaderText = "Mã Phiếu Mượn";
            dgvPhieuMuon.Columns[2].HeaderText = "Mã Sách";
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
            lbMaTaiLieuPhieuMuon.Text = cbxMaTLPM.SelectedValue.ToString();
        }

        private void btnAddMTLVaoList_Click(object sender, EventArgs e)
        {
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
            if ((/*p.SoSachDangMuon(maDG) +*/ lbListSachMuon.Items.Count) < 5)
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
                dgvPhieuTra.Columns[2].HeaderText = "Mã Quản Thư";
                btnXemChiTietPhieuTra.Visible = true;
                btnXoaPhieuTra.Visible = true;

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


                btnHuy_PhieuTra.Visible = false;
            }
        }

        private void btnXemChiTietPhieuTra_Click(object sender, EventArgs e)
        {
            btnXemChiTietPhieuTra.Visible = false;
            btnXoaPhieuTra.Visible = false;

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

        private void btnThemPhieuTra_Click(object sender, EventArgs e)
        {
            if (lbDanhSachSachTra.Items.Count > 0)
            {
                BLL_Phieu mpt = new BLL_Phieu();
                string maphieutra = mpt.LayMaPhieuTraTiepTheo();
                string mactpt = mpt.LayMaChiTietPhieuTraTiepTheo();
                string MaQT = "QT001";

                for (int i = 0; i < lbDanhSachSachTraHide.Items.Count; i++)
                {
                    string[] listsachtra = lbDanhSachSachTraHide.Items[i].ToString().Split('|');
                    string maphieumuon = listsachtra[0].Trim();
                    string masach = listsachtra[1].Trim();

                    if (i == 0)
                    {
                        BLL_Phieu busPhieu = new BLL_Phieu();
                        mpt.ThemPhieuTra(MaQT, maphieumuon, maphieutra, mactpt, masach);
                    }
                    BLL_Phieu busPhieuCT = new BLL_Phieu();
                    mpt.ThemChiTietPhieuTra(MaQT, maphieumuon, maphieutra, mactpt, masach);


                    if (mpt.LaySoSachCuaPM(maphieumuon) > lbDanhSachSachTra.Items.Count)
                    {
                        string maDG = mpt.LayMaDocGiaDePhat(maphieumuon);
                        mpt.TangSoLanViPham(maDG);
                    }
                    else if (mpt.LaySoNgayQuaHan(maphieumuon) > 0)
                    {
                        string maDG = mpt.LayMaDocGiaDePhat(maphieumuon);
                        mpt.TangSoLanViPham(maDG);
                    }
                }

                lbDanhSachSachTra.Items.Clear();
                lbDanhSachSachTraHide.Items.Clear();
                MessageBox.Show("Lập Phiếu Trả Thành Công !!!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để trả");
            }
        }

        private void btnAddSachTra_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Int32.Parse(lbDanhSachSachTra.Items.Count.ToString()); i++)
            {
                string value = lbDanhSachSachTra.Items[i].ToString().Trim();
                if (value == cbxSachPT.Text.ToString().Trim())
                {
                    MessageBox.Show("Tài Liệu Này Đã Có !!!");
                    return;
                }
            }
            lbDanhSachSachTra.Items.Add(cbxSachPT.Text);
            //lbDanhSachSachTraHide.Items.Add(cbxSachPT.SelectedValue);
            //lbDanhSachSachTra.Items.Add(string.Format("{0} | {1}", cbxMaPMCuaPT.Text, cbxSachPT.Text));
            lbDanhSachSachTraHide.Items.Add(string.Format("{0} | {1}", cbxMaPMCuaPT.Text, cbxSachPT.SelectedValue));
        }

        private void btnXoaMTLTrongList_Click(object sender, EventArgs e)
        {
            int index = lbListSachMuon.SelectedIndex;
            if (index >= 0)
            {
                lbListSachMuon.Items.RemoveAt(index);
                lbListSachMuonHide.Items.RemoveAt(index);
            }
        }

        private void btnXoaSachTra_Click(object sender, EventArgs e)
        {
            int index = lbDanhSachSachTra.SelectedIndex;
            if (index >= 0)
            {
                lbDanhSachSachTra.Items.RemoveAt(index);
                lbDanhSachSachTraHide.Items.RemoveAt(index);
            }
        }

        private void cbxMaPMCuaPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLL_Phieu phieu = new BLL_Phieu();
            string MPM = cbxMaPMCuaPT.Text;
            cbxSachPT.DataSource = phieu.LayDanhSachMaTaiLieuCuaPhieuMuon(MPM);
            cbxSachPT.DisplayMember = "TenSach";
            cbxSachPT.ValueMember = "MaSach";
        }

        private void lbListSachMuonHide_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbDanhSachSachTraHide_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabpage_ThemPhieuTra_Click(object sender, EventArgs e)
        {

        }

        private void cbxSachPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXemTatCaPhieuNhacNho_Click(object sender, EventArgs e)
        {
            BLL_Phieu busPhieu = new BLL_Phieu();
            dgvPhieuNhacNho.DataSource = busPhieu.XemPhieuNhacNho();
            dgvPhieuNhacNho.ReadOnly = false;
            dgvPhieuNhacNho.Columns[0].HeaderText = "Mã Độc Giả ";
            dgvPhieuNhacNho.Columns[1].HeaderText = "Số Lần Vi Phạm";

        }

        private void btnXoaPhieuNN_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhacNho.RowCount < 2)
            {
                return;
            }

            string mdg = dgvPhieuNhacNho[0, dgvPhieuNhacNho.CurrentRow.Index].Value.ToString();
            BLL_Phieu p = new BLL_Phieu();

            if (MessageBox.Show(string.Format("Xác nhận xóa Phiếu Nhắc Nhở Độc Giả {0}", mdg), "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int result = p.XoaPhieuNhacNho(mdg);

                if (result == 1)
                {
                    MessageBox.Show("Xóa thành công phiếu nhắc nhở của độc giả " + mdg);
                    btnXemTatCaPhieuNhacNho_Click(sender, e); // Refresh the data grid view
                }
                else
                {
                    MessageBox.Show("Chưa Thể Xóa Phiếu Này !");
                }
            }
        }

        private void btnThemPhieuNhacNho_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhacNho.RowCount < 2)
            {
                return;
            }

            string mdg = dgvPhieuNhacNho[0, dgvPhieuNhacNho.CurrentRow.Index].Value.ToString();
            BLL_Phieu p = new BLL_Phieu();

            if (MessageBox.Show(string.Format("Xác nhận Thêm Phiếu Nhắc Nhở Độc Giả {0}", mdg), "Xác nhận Thêm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                    p.TangSoLanViPham(mdg);

                    MessageBox.Show("Thêm thành công phiếu nhắc nhở của độc giả " + mdg);
                    btnXemTatCaPhieuNhacNho_Click(sender, e); // Refresh the data grid view
                
            }
            else
            {
                MessageBox.Show("Chưa Thể Thêm Phiếu Này !");
            }
        }

        private void btnGiamPhieuNhacNho_Click(object sender, EventArgs e)
        {

                if (dgvPhieuNhacNho.RowCount < 2)
                {
                    return;
                }

                string mdg = dgvPhieuNhacNho[0, dgvPhieuNhacNho.CurrentRow.Index].Value.ToString();
                BLL_Phieu p = new BLL_Phieu();

                if (MessageBox.Show(string.Format("Xác nhận Giảm Phiếu Nhắc Nhở Độc Giả {0}", mdg), "Xác nhận Giảm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    p.GiamSoLanViPham(mdg);

                    MessageBox.Show("Giảm thành công phiếu nhắc nhở của độc giả " + mdg);
                    btnXemTatCaPhieuNhacNho_Click(sender, e); // Refresh the data grid view

                }
                else
                {
                    MessageBox.Show("Chưa Thể Giảm Phiếu Này !");
                }

        }
    }
}
