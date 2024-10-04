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
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var sinhVien = new ThongTinSV
                    {
                        MaSV = txb_MSSV.Text, // Lấy mã sinh viên từ textbox
                        HoTen = txb_HoTen.Text, // Lấy họ tên sinh viên từ textbox
                        Diem = double.Parse(txb_Diem.Text), // Lấy điểm sinh viên từ textbox
                        MaKhoa = int.Parse(cbb_Nganh.SelectedValue.ToString()) // Lấy mã khoa từ combobox
                    };

                    context.ThongTinSV.Add(sinhVien); // Thêm sinh viên vào DbSet
                    context.SaveChanges(); // Lưu thay đổi vào database

                    MessageBox.Show("Thêm sinh viên thành công!");
                    LoadData(); // Hàm để load lại dữ liệu vào DataGridView
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi: Điểm nhập vào không hợp lệ. Vui lòng nhập lại!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    string maSV = txb_MSSV.Text;

                    // Tìm sinh viên theo MaSV
                    var sinhVien = context.ThongTinSV.SingleOrDefault(sv => sv.MaSV == maSV);

                    if (sinhVien != null)
                    {
                        sinhVien.HoTen = txb_HoTen.Text; // Cập nhật họ tên
                        sinhVien.Diem = double.Parse(txb_Diem.Text); // Cập nhật điểm
                        sinhVien.MaKhoa = int.Parse(cbb_Nganh.SelectedValue.ToString()); // Cập nhật mã khoa

                        context.SaveChanges(); // Lưu thay đổi vào database

                        MessageBox.Show("Cập nhật sinh viên thành công!");
                        LoadData(); // Hàm để load lại dữ liệu vào DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên!");
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi: Điểm nhập vào không hợp lệ. Vui lòng nhập lại!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    string maSV = txb_MSSV.Text;

                    // Tìm sinh viên theo MaSV
                    var sinhVien = context.ThongTinSV.SingleOrDefault(sv => sv.MaSV == maSV);

                    if (sinhVien != null)
                    {
                        context.ThongTinSV.Remove(sinhVien); // Xóa sinh viên
                        context.SaveChanges(); // Lưu thay đổi vào database

                        MessageBox.Show("Xóa sinh viên thành công!");
                        LoadData(); // Hàm để load lại dữ liệu vào DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadData()
        {
            using (var context = new Model1())
            {
                var sinhVienList = context.ThongTinSV
                                          .Select(sv => new
                                          {
                                              sv.MaSV,
                                              sv.HoTen,
                                              sv.Diem,
                                              TenKhoa = sv.Khoa.TenKhoa // Join để lấy tên khoa
                                          }).ToList();

                dtgv_ThongTin.DataSource = sinhVienList; // Gán dữ liệu vào DataGridView
            }
        }

        private void dtgv_ThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được bấm
                DataGridViewRow row = dtgv_ThongTin.Rows[e.RowIndex];

                // Hiển thị thông tin lên các TextBox tương ứng
                txb_MSSV.Text = row.Cells["MaSV"].Value.ToString(); // Lấy giá trị của cột MaSV
                txb_HoTen.Text = row.Cells["HoTen"].Value.ToString(); // Lấy giá trị của cột HoTen
                txb_Diem.Text = row.Cells["Diem"].Value.ToString(); // Lấy giá trị của cột Diem
                cbb_Nganh.Text = row.Cells["TenKhoa"].Value.ToString(); // Lấy tên khoa hiển thị trên ComboBox
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadKhoa();
        }
        private void LoadKhoa()
        {
            try
            {
                using (var context = new Model1())
                {
                    // Lấy danh sách các khoa từ database
                    var danhSachKhoa = context.Khoa.ToList();

                    // Gán danh sách khoa vào ComboBox
                    cbb_Nganh.DataSource = danhSachKhoa;
                    cbb_Nganh.DisplayMember = "TenKhoa"; // Tên hiển thị
                    cbb_Nganh.ValueMember = "MaKhoa";    // Giá trị thực tế khi chọn
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải danh sách khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txb_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            using (var context = new Model1())
            {
                // Lấy từ khóa tìm kiếm từ TextBox
                string searchText = txb_TimKiem.Text.ToLower();

                // Lọc sinh viên theo MaSV hoặc HoTen chứa từ khóa tìm kiếm
                var filteredSinhVien = context.ThongTinSV
                    .Where(sv => sv.MaSV.ToLower().Contains(searchText)
                              || sv.HoTen.ToLower().Contains(searchText))
                    .Select(sv => new
                    {
                        sv.MaSV,
                        sv.HoTen,
                        sv.Diem,
                        TenKhoa = sv.Khoa.TenKhoa // Lấy tên khoa từ bảng Khoa
                    })
                    .ToList();

                // Gán dữ liệu đã lọc vào DataGridView
                dtgv_ThongTin.DataSource = filteredSinhVien;

                if (filteredSinhVien.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên nào phù hợp.");
                }
            }
        }
    }
}
