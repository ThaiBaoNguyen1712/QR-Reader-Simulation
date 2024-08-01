using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace QR_Reader
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbbCamera.SelectedIndex].MonikerString);

            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //throw new NotImplementedException();
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();

            var result = reader.Decode(bitmap);
                if(result != null)
                    {
                       txtResult.Invoke(new MethodInvoker(delegate()
                       { 
                           txtResult.Text = result.ToString(); 
                       }));
                    }
                monitor.Image = bitmap;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                if(videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    monitor.Image = null;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    monitor.Image = null;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in filterInfoCollection)
                cbbCamera.Items.Add(device.Name);

            cbbCamera.SelectedIndex = 0;
        }

        private void dsadsaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QRManagement a = new QRManagement();
            a.ShowDialog();
        }

        private void vituarlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Simulator a = new Simulator();
            a.ShowDialog();
        }
    }
}
