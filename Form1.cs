using Accord.Video.FFMPEG;
using Accord.Video;
using Accord.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace AforgeCamereRecording
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FilterInfoCollection _videoCaptureDevices;
        private VideoCaptureDevice _finalVideo = null;
        private VideoCaptureDeviceForm _captureDevice;
        private Bitmap _video;
        private VideoFileWriter _fileWriter = new VideoFileWriter();
        private SaveFileDialog _saveAvi;
        private DateTime? _isDate;

        private void Form1_Load(object sender, EventArgs e)
        {
            _videoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            _captureDevice = new VideoCaptureDeviceForm();

            DevicesList();

            if (_captureDevice.ShowDialog(this) == DialogResult.OK)
            {
                VideoCaptureDevice videoSource = _captureDevice.VideoDevice;
                _finalVideo = _captureDevice.VideoDevice;
                _finalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
                _finalVideo.Start();
            }
        }

        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs e)
        {
            _video = (Bitmap)e.Frame.Clone();
            MainPicture.Image = (Bitmap)e.Frame.Clone();
            if (_fileWriter.IsOpen)
            {
                _fileWriter.WriteVideoFrame(_video);
            }
        }

        private void StartRecButton_Click(object sender, EventArgs e)
        {
            _saveAvi = new SaveFileDialog();
            _saveAvi.Filter = "Avi Files (*.avi)|*.avi";

            if (_saveAvi.ShowDialog() == DialogResult.OK)
            {
                const int frameRate = 8;
                const int bitRate = 5_000_000;
                int capturedHeight = _captureDevice.VideoDevice.VideoResolution.FrameSize.Height;
                int capturedWidth = _captureDevice.VideoDevice.VideoResolution.FrameSize.Width;
                _fileWriter.Open(_saveAvi.FileName, capturedWidth, capturedHeight, frameRate, VideoCodec.Default, bitRate);
            }

            statusLabel.Text = "Now Recording";
        }

        private void StopRecButton_Click(object sender, EventArgs e)
        {
            _fileWriter.Close();
            MainPicture.Image = null;
            this._finalVideo.Stop();
            _fileWriter.Close();
            MainPicture.Image = null;
            statusLabel.Text = "";
        }

        private void DevicesList()
        {
            if (_videoCaptureDevices.Count < 1)
            {
                return;
            }

            foreach (FilterInfo dev in _videoCaptureDevices)
            {
                DevicesBox.Items.Add(dev.Name);
            }

            DevicesBox.SelectedIndex = 0;
            _finalVideo = new VideoCaptureDevice(_videoCaptureDevices[DevicesBox.SelectedIndex].MonikerString);
            _finalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
            _finalVideo.Start();
        }

        private void SelectDeviceButton_Click(object sender, EventArgs e)
        {
            if (_captureDevice.ShowDialog(this) == DialogResult.OK)
            {   
                VideoCaptureDevice videoSource = _captureDevice.VideoDevice;
                _finalVideo = _captureDevice.VideoDevice;
                _finalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
                _finalVideo.Start();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_finalVideo is null)
            {
                return;
            }
            if (_finalVideo.IsRunning)
            {
                this._finalVideo.Stop();
                _fileWriter.Close();
            }
        }
    }
}
