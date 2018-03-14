using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWE.UserControls
{
    public partial class uQuetEmail : UserControl
    {
        public uQuetEmail()
        {
            InitializeComponent();
            txtQuetTenMien.DataBindings.Add("Enabled", radioButton1, "Checked");
        }
    }
}
