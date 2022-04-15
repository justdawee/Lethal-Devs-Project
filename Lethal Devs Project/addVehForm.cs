using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lethal_Devs_Project
{
    public partial class addVehForm : Form
    {
        public addVehForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection();
        MainForm panel = new MainForm(); //üzenetek kiírásához szükséges
        Vehicles veh = new Vehicles();

        bool typeclick, prodyearclick, ccmclick, mileageclick, licenseclick, vinclick = false;

        private void addVehForm_Load(object sender, EventArgs e)
        {

        }

        private void comboOwner_Click(object sender, EventArgs e)
        {
            if (conn.checkEmptyTable("users") == false)
            {
                comboOwner.Items.Clear();
                var users = conn.getUsersTable();
                foreach (var user in users)
                {
                    var format = $"{user.Name} (ID: {user.Id})";
                    comboOwner.Items.Add(format);
                }
            }
        }
        private void txtboxType_Click(object sender, EventArgs e)
        {
            if (typeclick == false)
            {
                txtboxType.Text = "";
                typeclick = true;
            }
        }
        private void txtboxProdyear_Click(object sender, EventArgs e)
        {
            if (prodyearclick == false)
            {
                txtboxProdyear.Text = "";
                prodyearclick = true;
            }
        }
        private void comboEngine_Click(object sender, EventArgs e)
        {
            comboEngine.Items.Clear();
            foreach (var engine in veh.Engines)
            {
                comboEngine.Items.Add(engine);
            }
        }
        private void textboxCcm_Click(object sender, EventArgs e)
        {
            if (ccmclick == false)
            {
                textboxCcm.Text = "";
                ccmclick = true;
            }
        }
        private void comboFuel_Click(object sender, EventArgs e)
        {
            comboFuel.Items.Clear();
            foreach (var fuel in veh.Fueltypes)
            {
                comboFuel.Items.Add(fuel);
            }
        }
        private void textboxMileage_Click(object sender, EventArgs e)
        {
            if (mileageclick == false)
            {
                textboxMileage.Text = "";
                mileageclick = true;
            }
        }
        private void comboColor_Click(object sender, EventArgs e)
        {
            comboColor.Items.Clear();
            foreach (var color in veh.VehColors)
            {
                comboColor.Items.Add(color);
            }
        }
        private void textboxLicense_Click(object sender, EventArgs e)
        {
            if (licenseclick == false)
            {
                textboxLicense.Text = "";
                licenseclick = true;
            }
        }
        private void textboxVin_Click(object sender, EventArgs e)
        {
            if (vinclick == false)
            {
                textboxVin.Text = "";
                vinclick = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            var ownerUnformat = comboOwner.Text;
            var ownerFormat = ownerUnformat.Split('(')[0];
            conn.AddVehicle(
                ownerFormat,
                txtboxType.Text,
                txtboxProdyear.Text,
                textboxVin.Text,
                textboxLicense.Text,
                comboColor.Text,
                textboxMileage.Text,
                comboEngine.Text,
                Convert.ToInt32(textboxCcm.Text),
                comboFuel.Text,
                1
                );

            panel.ShowMessage("A jármű hozzáadásra került az adatbázisba.", "Siker");

            comboOwner.Items.Clear();
            txtboxType.Text = "Volkswagen Golf";
            txtboxProdyear.Text = "2021";
            textboxVin.Text = "WVWBA7AJXCWXXXXXX";
            textboxMileage.Text = "32652";
            comboEngine.Items.Clear();
            textboxCcm.Text = "1568";
            comboFuel.Items.Clear();

            typeclick = false; prodyearclick = false; ccmclick = false; mileageclick = false; licenseclick = false; vinclick = false;

            FormsClass.secondform.refreshList();

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
