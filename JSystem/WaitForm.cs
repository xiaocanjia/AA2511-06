using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace JSystem
{
    public partial class WaitForm : UIForm
    {
        public WaitForm()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon("Logo.ico");
        }
    }
}
