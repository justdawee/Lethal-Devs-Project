using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lethal_Devs_Project
{
    public partial class editVehForm : Form
    {
        SqlConnection conn = new SqlConnection();
        MainForm panel = new MainForm(); //üzenetek kiírásához szükséges
        Vehicles veh = new Vehicles();
        public editVehForm()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
