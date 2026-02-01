using System;
using System.Windows.Forms;
using JLogging;
using Sunny.UI;

namespace JSystem.Perform
{
    public enum EPopupType
    {
        EMERGENCY,
        CONFIRM,
        ALARM,
        WARNING
    }

    public partial class Popup : UIForm
    {
        public DialogResult CurrRet = DialogResult.None;

        public Action OnHide;

        public Popup()
        {
            InitializeComponent();
        }

        public void Show(EPopupType type, string title, string msg)
        {
            Text = title;
            Lb_Content.Text = msg;
            switch (type)
            {
                case EPopupType.EMERGENCY:
                case EPopupType.CONFIRM:
                    Btn_Abort.Visible = false;
                    Btn_Retry.Visible = false;
                    Btn_Ignore.Visible = false;
                    Btn_Confirm.Visible = true;
                    break;
                case EPopupType.ALARM:
                    Btn_Abort.Visible = true;
                    Btn_Retry.Visible = true;
                    Btn_Ignore.Visible = false;
                    Btn_Confirm.Visible = false;
                    break;
                case EPopupType.WARNING:
                    Btn_Abort.Visible = true;
                    Btn_Retry.Visible = true;
                    Btn_Ignore.Visible = true;
                    Btn_Confirm.Visible = false;
                    break;
            }
            Show();
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            CurrRet = DialogResult.OK;
            LogManager.Instance.AddLog("弹窗", "手动点击确认按钮", LogLevels.Debug);
            OnHide();
        }

        private void Btn_Abort_Click(object sender, EventArgs e)
        {
            CurrRet = DialogResult.Abort;
            LogManager.Instance.AddLog("弹窗", "手动点击中止按钮", LogLevels.Debug);
            OnHide();
        }

        private void Btn_Retry_Click(object sender, EventArgs e)
        {
            CurrRet = DialogResult.Retry;
            LogManager.Instance.AddLog("弹窗", "手动点击重试按钮", LogLevels.Debug);
            OnHide();
        }

        private void Btn_Ignore_Click(object sender, EventArgs e)
        {
            CurrRet = DialogResult.Ignore;
            LogManager.Instance.AddLog("弹窗", "手动点击忽略按钮", LogLevels.Debug);
            OnHide();
        }
    }
}
