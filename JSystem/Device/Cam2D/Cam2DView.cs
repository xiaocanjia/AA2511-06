using System;
using System.Windows.Forms;
using Sunny.UI;
using Camera2DSDK;
using HalconDotNet;

namespace JSystem.Device
{
    public partial class Cam2DView : UserControl
    {
        private Camera2D _device;

        public Cam2DView()
        {
            InitializeComponent();
        }

        public Cam2DView(Camera2D device) : this()
        {
            _device = device;
            device.OnUpdateStatus += UpdateStatus;
        }

        public override void Refresh()
        {
            base.Refresh();
            CbB_Cam_Type.Items.Clear();
            foreach (ECam2DType type in Enum.GetValues(typeof(ECam2DType)))
                CbB_Cam_Type.Items.Add(type.ToString());
            CbB_Cam_Type.SelectedIndex = _device.CamType;
            TB_Gain.Text = _device.Gain.ToString();
            CB_Enabled.Checked = _device.IsEnable;
            Btn_Connect.Selected = _device.CheckConnection();
            CB_Enabled.CheckedChanged += new EventHandler(CB_Enabled_CheckedChanged);
        }

        private void CB_Enabled_CheckedChanged(object sender, EventArgs e)
        {
            _device.IsEnable = CB_Enabled.Checked;
        }

        private void CbB_Cam_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            _device.CamType = CbB_Cam_Type.SelectedIndex;
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (!Btn_Connect.Selected)
            {
                if (!_device.Connect())
                    UIMessageBox.Show("相机连接失败，可能被占用或者相机信息填写错误");
            }
            else
            {
                _device.DisConnect();
            }
        }

        public void UpdateStatus(bool isConnected)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => { UpdateStatus(isConnected); }));
            }
            else
            {
                if (Btn_Connect.Selected == isConnected)
                    return;
                if (isConnected)
                {
                    Btn_Connect.Selected = true;
                    foreach (Control control in Controls)
                    {
                        if (control is UIComboBox || control is UITextBox)
                            control.Enabled = false;
                    }
                }
                else
                {
                    Btn_Connect.Selected = false;
                    foreach (Control control in Controls)
                    {
                        if (control is UIComboBox || control is UITextBox)
                            control.Enabled = true;
                    }
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                UpdateValue();
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            UITextBox tb = sender as UITextBox;
            UpdateValue();
        }

        private void UpdateValue()
        {
            try
            {
                _device.Gain = Convert.ToSingle(TB_Gain.Text);
            }
            catch
            {
                UIMessageBox.Show("参数格式填写错误，请检查！");
                return;
            }
        }

        private void Btn_Grab_Click(object sender, EventArgs e)
        {
            _device.Open();
            _device.GrabImageRGB(out HImage image);
            _device.Close();
            double startX = 0.0;
            double startY = 0.0;
            double width = 0.0;
            double height = 0.0;
            image.GetImageSize(out int imgWidth, out int imgHeight);
            if (imgWidth == 0 || imgHeight == 0)
                return;
            double imgRatio = imgWidth / (double)imgHeight;
            double winRatio = Width / (double)Height;

            if (imgRatio >= winRatio)
            {
                width = imgWidth;
                height = imgWidth / winRatio;
                startX = 0;
                startY = (height - imgHeight) / 2;
            }
            else
            {
                width = imgHeight * winRatio;
                height = imgHeight;
                startX = (width - imgWidth) / 2;
                startY = 0;
            }
            HControl.HalconWindow.SetPart(-startY, -startX, height - startY - 1, width - startX - 1);
            HControl.HalconWindow.DispObj(image);
        }
    }
}
