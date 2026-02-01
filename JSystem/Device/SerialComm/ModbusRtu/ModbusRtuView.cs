using System;
using System.Windows.Forms;

namespace JSystem.Device
{
    public partial class ModbusRtuView : SerialCommView
    {
        public ModbusRtuView(ModbusRtu device)
        {
            InitializeComponent();
            _device = device;
        }

        public override void Refresh()
        {
            base.Refresh();
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
            UpdateValue();
        }

        private void UpdateValue()
        {
            try
            {
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
            }
        }

        private void Btn_Read_Coils_Click(object sender, EventArgs e)
        {
            ushort addr = 0;
            ushort count = 0;
            byte sAddr = 0;
            try
            {
                addr = Convert.ToUInt16(TB_Read_Coils_Addr.Text);
                count = Convert.ToUInt16(TB_Read_Coils_Count.Text);
                sAddr = Convert.ToByte(TB_Read_Coils_SAddr.Text);
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
                return;
            }
            Lbl_Coils_Value.Text = "";
            byte[] data = ((ModbusRtu)_device).ReadCoils(sAddr, addr, count);
            foreach (byte d in data)
                Lbl_Coils_Value.Text += d.ToString("X2");
        }

        private void Btn_Write_Coils_Click(object sender, EventArgs e)
        {
            ushort addr = 0;
            byte[] data;
            byte sAddr = 0;
            try
            {
                addr = Convert.ToUInt16(TB_Write_Coils_Addr.Text);
                sAddr = Convert.ToByte(TB_Write_Coils_SAddr.Text);
                string[] sArr = TB_Write_Coils_Data.Text.Split(' ');
                data = new byte[sArr.Length];
                for (int i = 0; i < sArr.Length; i++)
                    data[i] = Convert.ToByte(sArr[i], 16);
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
                return;
            }
            ((ModbusRtu)_device).WriteCoils(sAddr, addr, data);
        }

        private void Btn_Read_HRs_Click(object sender, EventArgs e)
        {
            ushort addr = 0;
            ushort count = 0;
            byte sAddr = 0;
            try
            {
                addr = Convert.ToUInt16(TB_Read_HRs_Addr.Text);
                count = Convert.ToUInt16(TB_Read_HRs_Count.Text);
                sAddr = Convert.ToByte(TB_Read_HRs_SAddr.Text);
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
                return;
            }
            Lbl_HRs_Value.Text = "";
            byte[] data = ((ModbusRtu)_device).ReadHoldingRegisters(sAddr, addr, count);
            foreach (byte d in data)
                Lbl_HRs_Value.Text += d.ToString("X2") + " ";
        }

        private void Btn_Write_HRs_Click(object sender, EventArgs e)
        {
            ushort addr = 0;
            byte[] data;
            byte sAddr = 0;
            try
            {
                addr = Convert.ToUInt16(TB_Write_HRs_Addr.Text);
                sAddr = Convert.ToByte(TB_Write_HRs_SAddr.Text);
                string[] sArr = TB_Write_HRs_Data.Text.Split(' ');
                data = new byte[sArr.Length];
                for (int i = 0; i < sArr.Length; i++)
                    data[i] = Convert.ToByte(sArr[i]);
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
                return;
            }
            ((ModbusRtu)_device).WriteHoldingRegisters(sAddr, addr, data);
        }
    }
}
