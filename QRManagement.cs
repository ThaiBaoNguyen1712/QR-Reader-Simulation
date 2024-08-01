using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Reader
{
    public partial class QRManagement : Form
    {
        public QRManagement()
        {
            InitializeComponent();
        }
        public static int Id = -1;
        ReadQREntities data = new ReadQREntities();
        private void QRManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'readQRDataSet1.Brand_Code' table. You can move, or remove it, as needed.
         
            List<Brand_Code> brands = new List<Brand_Code>();
            brands = data.Brand_Code.ToList();
            dataGridView1.DataSource = brands;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            if (txtName == null || txtDescription == null)
            {
                MessageBox.Show("Thiếu thông tin.");
                return;
            }
           
            // Tạo đối tượng Brand_Code và gán giá trị
            Brand_Code brand = new Brand_Code
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
         
                Created_at = DateTime.Now,
                Updated_at = DateTime.Now,
            };

            // Thêm đối tượng vào DbSet và lưu thay đổi
            data.Brand_Code.Add(brand);

            try
            {
                data.SaveChanges();
                MessageBox.Show("Thêm thành công.");
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving changes: {ex.Message}");
            }

            // Làm sạch các điều khiển sau khi thêm thành công
            txtName.Clear();
            txtDescription.Clear();
        }


        private void RefreshDataGridView()
        {
            // Tải lại dữ liệu từ cơ sở dữ liệu vào DataGridView
            var brands = data.Brand_Code.ToList();
            dataGridView1.DataSource = brands;
        }
        // Bắt sự kiện click vào đầu dòng của datagridview để fill dữ liệu lên các textbox
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value == DBNull.Value ? "" : dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value == DBNull.Value ? "" : dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            GenerateQRCode generateQRCode = new GenerateQRCode();
          // Tạo mã QR và gán cho PictureBox
             pcCode.Image = generateQRCode.CreateQRCode(Id.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(Id>0)
            {
                Brand_Code brand = data.Brand_Code.Where(x=>x.Id== Id).FirstOrDefault(); 
                if (brand != null)
                {
                  
                    if (txtName == null || txtDescription == null)
                    {
                        MessageBox.Show("Thiếu thông tin.");
                        return;
                    }

                    brand.Name = txtName.Text;
                    brand.Description = txtDescription.Text;
              
                    try
                    {
                        data.SaveChanges();
                        MessageBox.Show("Sửa thành công !");
                        RefreshDataGridView();
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Đã có lỗi !");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thương hiệu bạn yêu cầu !");
            }
            txtName.Clear();
            txtDescription.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                // Hiển thị hộp thoại xác nhận
                var result = MessageBox.Show("Bạn có chắc rằng muốn xóa ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Tìm đối tượng Brand_Code theo Id
                    Brand_Code brand = data.Brand_Code.Where(x => x.Id == Id).FirstOrDefault();

                    if (brand != null)
                    {
                        try
                        {
                            // Xóa đối tượng và lưu thay đổi
                            data.Brand_Code.Remove(brand);
                            data.SaveChanges();
                            MessageBox.Show("Xóa thành công!");
                            RefreshDataGridView();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thương hiệu bạn yêu cầu !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Id không hợp lệ, vui lòng kiểm tra lại.");
            }
        }

        //private void cbbCodeType_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    // Kiểm tra xem có giá trị đã chọn hay không
        //    if (cbbCodeType.SelectedItem != null)
        //    {
        //        string selectedText = txtName.Text.ToString();

        //        GenerateQRCode generateQRCode = new GenerateQRCode();
        //        // Tạo mã QR và gán cho PictureBox
        //        pcCode.Image = generateQRCode.CreateQRCode(selectedText);
        //    }

        //}

     
    }
}
