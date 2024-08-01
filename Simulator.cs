using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using ZXing;

namespace QR_Reader
{
    public partial class Simulator : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        ReadQREntities data = new ReadQREntities();

        private bool IsRunning = false;
        private bool qrCodeChecked = false;
        public Simulator()
        {
            InitializeComponent();
            pnBackgroundBox.Location = new Point(383, 110);
            pnBackgroundBox.SendToBack();
            

        }

        private void Simulator_Load(object sender, EventArgs e)
        {
            List<Code_history> history = new List<Code_history>();
            dataGridView1.DataSource = history;
            filterCbbBrand();
            filterCbbDevice();
            RandomQRCode();
        }

        private void filterCbbBrand()
        {
            var brands = data.Brand_Code.ToList();

            foreach(var brand in brands)
            {
                cbbSP.Items.Add(brand.Name);
            }
            cbbSP.SelectedIndex = 0;
        }

        private void filterCbbDevice()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cbbDevice.Items.Add(device.Name);

            cbbDevice.SelectedIndex = 0;
        }


        private void InitializeCustomComponents()
        {
            // Thiết lập Timer
            timer1 = new System.Windows.Forms.Timer
            {
                Interval = 1
            };
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Di chuyển Panel sang phải
            pnBackgroundBox.Left += 15;

            if (Math.Abs(pnBackgroundBox.Left - 383) <= 15 && pnBackgroundBox.Top == 110)
            {
                if (!qrCodeChecked)
                {
                    CheckQRCode();
                    qrCodeChecked = true; // Đặt cờ để ngăn chặn gọi lại CheckQRCode
                }
            }
            else
            {
                qrCodeChecked = false; // Đặt lại cờ khi pnBackgroundBox ra khỏi phạm vi vị trí
            }

            // Kiểm tra nếu Panel đã ra khỏi khung hình
            if (pnBackgroundBox.Left > this.ClientSize.Width)
            {
                // Đặt Panel trở lại điểm bắt đầu bên trái
                pnBackgroundBox.Left = -pnBackgroundBox.Width;
                RandomQRCode();
                UpdatePanelColor(Color.OldLace); // Đặt màu nền để báo hiệu panel mới xuất hiện   
            }
        
        }

        // Đảm bảo rằng Panel sẽ được đặt chính xác khi thay đổi kích thước Form
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            pnBackgroundBox.Top = (this.ClientSize.Height - pnBackgroundBox.Height) / 2;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            InitializeCustomComponents();
            IsRunning = true;
            btnStart.Text = "Đang chạy";
            btnStart.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnBackgroundBox.Location = new Point(383, 110);
            timer1.Stop();
            IsRunning=false;
            RandomQRCode();
            UpdatePanelColor(Color.OldLace);
            btnStart.Text = "Bắt đầu";
            btnStart.Enabled = true;
            qrCodeChecked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            IsRunning=false;
            btnStart.Enabled = true;
            btnStart.Text = "Tiếp tục";
        }
        private void AddRecord_Code()
        {
            int id_brand = data.Brand_Code.Where(x => x.Name == cbbSP.SelectedItem.ToString()).Select(n=>n.Id).FirstOrDefault();
            int id_Device = data.Readers.Where(x => x.Name == cbbDevice.SelectedItem.ToString()).Select(n => n.Id).FirstOrDefault();

            //Nếu chưa tồn tại reader tạo mới
            if(id_Device == 0)
            {
                var reader = AddDevice();
                id_Device = reader.Id;
            }
            //Thêm thiết bị đọc mới
            var record = new Code_history
            {
                Brand_Id = id_brand,
                Reader_Id = id_Device,
                Status = "Approved",
                Created_at = DateTime.Now,
                Updated_at = DateTime.Now
            };
            data.Code_history.Add(record);
            try
            {
                data.SaveChanges();
                RefreshGridView();
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message);
            }
        }
        private Reader AddDevice()
        {
            var device = new Reader
            {
                Name = cbbDevice.SelectedItem.ToString(),
                Description = "Auto add",
                Created_at = DateTime.Now,
                Updated_at = DateTime.Now
            };

            data.Readers.Add(device);

            try
            {
                data.SaveChanges();
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message);
            }
            return device;
        }
        private void RandomQRCode()
        {
            GenerateQRCode generate = new GenerateQRCode();

            // Lấy ID của thương hiệu hiện tại
            int idBrand = data.Brand_Code.Where(x => x.Name == cbbSP.SelectedItem.ToString()).Select(n => n.Id).FirstOrDefault();

            // Lấy danh sách tất cả ID từ cơ sở dữ liệu
            var allIds = data.Brand_Code.Select(x => x.Id).ToList();

            if (allIds.Count <= 1)
            {
                MessageBox.Show("Không đủ mã QR để mô phỏng.");
                timer1.Stop();
                return;
            }

            // Chọn một ID sai
            var random = new Random();
            int wrongId;
            do
            {
                wrongId = allIds[random.Next(allIds.Count)];
            } while (wrongId == idBrand);

            // Xác suất 30% chọn mã QR sai
            bool isWrong = random.Next(10) <3 ; // 30% xác suất chọn mã sai
            int selectedId = isWrong ? wrongId : idBrand;

            // Sinh mã QR và hiển thị
            pcCode.Image = generate.CreateQRCode(selectedId.ToString());
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //throw new NotImplementedException();
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();

            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txtReadCode.Invoke(new MethodInvoker(delegate ()
                {
                    txtReadCode.Text = result.ToString();
                    int id_brand = int.Parse(txtReadCode.Text);
                    string brand = data.Brand_Code.Where(x => x.Id == id_brand).Select(n=>n.Name).FirstOrDefault();
                    txtBrand.Text = brand;
                
                }));
            }
            Monitor.Image = bitmap;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
         
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbbDevice.SelectedIndex].MonikerString);

            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

            btnClose.Visible = true;
            btnOpen.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    // Dừng thiết bị video
                    videoCaptureDevice.Stop();
                }

                // Giải phóng tài nguyên của videoCaptureDevice
                videoCaptureDevice = null;
            }

            // Giải phóng tài nguyên hình ảnh hiện tại nếu có
            if (Monitor.Image != null)
            {
                Monitor.Image.Dispose();
                Monitor.Image = null;
            }

            // Cập nhật giao diện người dùng
            btnClose.Visible = false;
            btnOpen.Visible = true;
        }


        private async void CheckQRCode()
        {
            if (videoCaptureDevice == null || !videoCaptureDevice.IsRunning)
            {
                await StopConveyorWithErrorAsync("Vui lòng bật máy quét mã QR");
                return;
            }

            int id_brand = data.Brand_Code
                               .Where(x => x.Name == cbbSP.SelectedItem.ToString())
                               .Select(x => x.Id)
                               .FirstOrDefault();

            if (int.Parse(txtReadCode.Text.ToString()) == id_brand && IsRunning)
            {
                // Ghi record vào cơ sở dữ liệu và đặt màu nền xanh
                AddRecord_Code();
                UpdatePanelColor(Color.Green);
            }
            else
            {
                await StopConveyorWithErrorAsync("Không trùng khớp sản phẩm trong dây chuyền !");
            }
        }

        private async Task StopConveyorWithErrorAsync(string errorMessage)
        {
            // Đặt màu nền đỏ ngay lập tức và dừng dây chuyền
            UpdatePanelColor(Color.Red);
            timer1.Stop();
            IsRunning = false;
            await Task.Run(() => MessageBox.Show(errorMessage));
        }

        private void UpdatePanelColor(Color color)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    pnBackgroundBox.BackColor = color;
                }));
            }
            else
            {
                pnBackgroundBox.BackColor = color;
            }
        }


        private void RefreshGridView()
        {
           var history = data.Code_history.Take(50).OrderByDescending(x => x.Id).ToList();
            dataGridView1.DataSource = history;
        }
    }
}
