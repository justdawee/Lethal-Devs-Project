using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lethal_Devs_Project.MainFormTabs
{
    public partial class BottomTab : Form
    {
        public BottomTab()
        {
            InitializeComponent();
        }

        private void BottomTab_Load(object sender, EventArgs e)
        {
            FormsClass.bottomform = this;
        }
    }
}
