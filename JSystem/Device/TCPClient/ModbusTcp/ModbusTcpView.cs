using System;
using System.Windows.Forms;

namespace JSystem.Device
{
    public partial class ModbusTcpView : TCPClientView
    {
        public ModbusTcpView(ModbusTcp device)
        {
            InitializeComponent();
            _device = device;
        }
        
        private void Btn_Read_Coils_Click(object sender, EventArgs e)
        {
            ushort addr = 0;
            ushort count = 0;
            try
            {
                addr = Convert.ToUInt16(TB_Read_Coils_Addr.Text);
                count = Convert.ToUInt16(TB_Read_Coils_Count.Text);
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
                return;
            }
            Lbl_Coils_Value.Text = "";
            byte[] data = ((ModbusTcp)_device).ReadCoils(Convert.ToByte(TB_Slave_Addr.Text), addr, count);
            foreach (byte d in data)
                Lbl_Coils_Value.Text += d.ToString("X2");
        }

        private void Btn_Write_Coils_Click(object sender, EventArgs e)
        {
            ushort addr = 0;
            byte[] data;
            try
            {
                addr = Convert.ToUInt16(TB_Write_Coils_Addr.Text);
                string[] sArr = TB_Write_Coils_Data.Text.Split(' ');
                data = new byte[sArr.Length];
                for (int i = 0; i < sArr.Length; i++)
                    data[i] = Convert.ToByte(sArr[i]);
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
                return;
            }
            ((ModbusTcp)_device).WriteCoils(Convert.ToByte(TB_Slave_Addr.Text), addr, data);
        }

        private void Btn_Read_HRs_Click(object sender, EventArgs e)
        {
            ushort addr = 0;
            ushort count = 0;
            try
            {
                addr = Convert.ToUInt16(TB_Read_HRs_Addr.Text);
                count = Convert.ToUInt16(TB_Read_HRs_Count.Text);
            }
            catch
            {
                MessageBox.Show("输入字符串格式不正确！");
                return;
            }
            Lbl_HRs_Value.Text = "";
            byte[] data = ((ModbusTcp)_device).ReadHoldingRegisters(Convert.ToByte(TB_Slave_Addr.Text), addr, count);
            foreach (byte d in data)
                Lbl_HRs_Value.Text += d.ToString("X2") + " ";
        }

        private void Btn_Write_HRs_Click(object sender, EventArgs e)
        {
            ushort addr = 0;
            byte[] data;
            try
            {
                addr = Convert.ToUInt16(TB_Write_HRs_Addr.Text);
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
            ((ModbusTcp)_device).WriteHoldingRegisters(Convert.ToByte(TB_Slave_Addr.Text), addr, data);
        }
    }
}
