using JSystem.User;
using Meas2D;
using Sunny.UI;
using System;
using System.Threading.Tasks;

namespace JSystem.Station
{
    public partial class VisionPage : UIPage
    {
        private StationManager _manager;

        public Meas2DPage Page2D1 = new Meas2DPage();

        public Meas2DPage Page2D2 = new Meas2DPage();

        public Meas2DPage Page2D3 = new Meas2DPage();

        public Meas2DPage Page2D4 = new Meas2DPage();

        private TestStation _testStnL = null;

        private TestStation _testStnR = null;

        private TransferStation _transStn = null;

        public VisionPage()
        {
            InitializeComponent();
            Panel1.Controls.Add(Page2D1);
            Page2D1.Show();
            Panel2.Controls.Add(Page2D2);
            Page2D2.Show();
            Panel3.Controls.Add(Page2D3);
            Page2D3.Show();
            Panel4.Controls.Add(Page2D4);
            Page2D4.Show();
        }

        public void Init(StationManager manager)
        {
            _manager = manager;
            _testStnL = (TestStation)_manager.GetStation("左测试工站");
            _testStnR = (TestStation)_manager.GetStation("右测试工站");
            _transStn = (TransferStation)_manager.GetStation("搬运工站");
        }

        public void UpdateUI()
        {
            Page2D1.Refresh(_transStn.Meas2DMgrA);
            Page2D2.Refresh(_transStn.Meas2DMgrB);
            Page2D3.Refresh(_testStnL.Meas2DMgr);
            Page2D4.Refresh(_testStnR.Meas2DMgr);
        }

        public void SetEnabled(bool isEnabled)
        {
            bool enabled = isEnabled & (LoginForm.User != "操作员");
            Btn_ShotA.Enabled = enabled;
            Page2D1.Enabled = LoginForm.User != "操作员";
            Page2D2.Enabled = LoginForm.User != "操作员";
            Page2D3.Enabled = LoginForm.User != "操作员";
            Page2D4.Enabled = LoginForm.User != "操作员";
        }

        private void Btn_ShotA_Click(object sender, EventArgs e)
        {
            new Task(() => {
                Invoke(new Action(() => Btn_ShotA.Enabled = false));
                _transStn.GrabImage("", "A");
                Invoke(new Action(() => Btn_ShotA.Enabled = true));
            }).Start();
        }

        private void Btn_ShotB_Click(object sender, EventArgs e)
        {
            new Task(() => {
                Invoke(new Action(() => Btn_ShotA.Enabled = false));
                _transStn.GrabImage("", "B");
                Invoke(new Action(() => Btn_ShotA.Enabled = true));
            }).Start();
        }

        private void Btn_ShotL_Click(object sender, EventArgs e)
        {
            new Task(() => {
                Invoke(new Action(() => Btn_ShotL.Enabled = false));
                _testStnL.GrabImage("", out double[] offset);
                Invoke(new Action(() => Btn_ShotL.Enabled = true));
            }).Start();
        }

        private void Btn_ShotR_Click(object sender, EventArgs e)
        {
            new Task(() => {
                Invoke(new Action(() => Btn_ShotR.Enabled = false));
                _testStnR.GrabImage("", out double[] offset);
                Invoke(new Action(() => Btn_ShotR.Enabled = true));
            }).Start();
        }

        private void Btn_CalibL_Click(object sender, EventArgs e)
        {
            new Task(() => {
                Invoke(new Action(() => Btn_CalibL.Enabled = false));
                _testStnL.Calib();
                Invoke(new Action(() => Btn_CalibL.Enabled = true));
            }).Start();
        }

        private void Btn_CalibR_Click(object sender, EventArgs e)
        {
            new Task(() => {
                Invoke(new Action(() => Btn_CalibR.Enabled = false));
                _testStnR.Calib();
                Invoke(new Action(() => Btn_CalibR.Enabled = true));
            }).Start();
        }
    }
}
