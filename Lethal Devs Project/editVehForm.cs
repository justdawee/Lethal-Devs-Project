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

        private List<string> editvehlist = new List<string>();

        public editVehForm()
        {
            InitializeComponent();
        }

        private void editVehForm_Load(object sender, EventArgs e)
        {
            loadComboData();
            processVehList();
            loadSelectedData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var vehid = hiddenId.Text;
            var ownerUnformat = comboOwner.Text;
            var ownerFormat = ownerUnformat.Split('(')[0];
            var type = txtboxType.Text;
            var prodyear = txtboxProdyear.Text;
            var vin = textboxVin.Text;
            var license = textboxLicense.Text;
            var color = comboColor.Text;
            var mileage = textboxMileage.Text;
            var engine = comboEngine.Text;
            var ccm = textboxCcm.Text;
            var fueltype = comboFuel.Text;

            var command = "UPDATE vehicles SET owner = '" + ownerFormat + "', type = '" + type + "', prodyear = '" + prodyear + "', vin = '" + vin + "', license = '" + license + "', color = '" + color + "', mileage = '" + mileage + "', engine = '" + engine + "', ccm = '" + ccm + "', fueltype = '" + fueltype + "' WHERE vehicles.vehid = " + vehid + ";";
            conn.Query(command);

            panel.ShowMessage("A jármű módosítása felkerült az adatbázisba.", "Siker");
            FormsClass.secondform.refreshVehiclesList();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void processVehList()
        {
            if (conn.checkEmptyTable("vehicles") == false)
            {
                var vehicles = conn.getVehicleTable();
                foreach (var vehicle in vehicles)
                {
                    var listformat = $"{vehicle.Id}^{vehicle.Prodyear}^{vehicle.Type}^{vehicle.Owner}^{vehicle.Engine}^{vehicle.Ccm}^{vehicle.Fueltype}^{vehicle.Color}^{vehicle.Mileage}^{vehicle.License}^{vehicle.Vin}^{vehicle.Added}^{vehicle.Active}";
                    editvehlist.Add(listformat);
                }
            }
        }
        public void loadSelectedData()
        {
            var secondform = FormsClass.secondform;
            var selectedRow = editvehlist[secondform.SelectedIndex];

            var data = selectedRow.Split('^');
            var ownerIndex = whichOwnerIndex((string)data[3]);
            var engineIndex = whichEngineIndex((string)data[4]);
            var fuelIndex = whichFuelIndex((string)data[6]);
            var colorIndex = whichColorIndex((string)data[7]);

            comboOwner.SelectedIndex = ownerIndex;
            txtboxType.Text = data[2];
            txtboxProdyear.Text = data[1];
            comboEngine.SelectedIndex = engineIndex;
            textboxCcm.Text = data[5];
            comboFuel.SelectedIndex = fuelIndex;
            textboxMileage.Text = data[8];
            comboColor.SelectedIndex = colorIndex;
            textboxLicense.Text = data[9];
            textboxVin.Text = data[10];
            hiddenId.Text = data[0];
        }
        private void loadComboData()
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

            comboEngine.Items.Clear();
            foreach (var engine in veh.Engines)
            {
                comboEngine.Items.Add(engine);
            }

            comboFuel.Items.Clear();
            foreach (var fuel in veh.Fueltypes)
            {
                comboFuel.Items.Add(fuel);
            }

            comboColor.Items.Clear();
            foreach (var color in veh.VehColors)
            {
                comboColor.Items.Add(color);
            }
        }

        public int whichFuelIndex(string fuel)
        {
            var index = 0;

            for (int i = 0; i < veh.Fueltypes.Count; i++)
            {
                if (veh.Fueltypes[i] == fuel)
                {
                    index = i;
                }
            }
            return index;
        }
        public int whichOwnerIndex(string owner)
        {
            var index = 0;
            if (conn.checkEmptyTable("users") == false)
            {
                var users = conn.getUsersTable();
                List<string> owners = new List<string>();

                foreach (var user in users)
                {
                    owners.Add(user.Name);
                }

                for (int i = 0; i < users.Count; i++)
                {
                    if (owners[i] == owner)
                    {
                        index = i;
                    }
                }
            }
            return index;
        }
        public int whichColorIndex(string color)
        {
            var index = 0;

            for (int i = 0; i < veh.VehColors.Count; i++)
            {
                if (veh.VehColors[i] == color)
                {
                    index = i;
                }
            }
            return index;
        }
        public int whichEngineIndex(string engine)
        {
            var index = 0;

            for (int i = 0; i < veh.Engines.Count; i++)
            {
                if (veh.Engines[i] == engine)
                {
                    index = i;
                }
            }
            return index;
        }

        private void comboOwner_Click(object sender, EventArgs e)
        {
            
        }
        private void txtboxType_Click(object sender, EventArgs e)
        {

        }
        private void txtboxProdyear_Click(object sender, EventArgs e)
        {

        }
        private void comboEngine_Click(object sender, EventArgs e)
        {
            
        }
        private void textboxCcm_Click(object sender, EventArgs e)
        {

        }
        private void comboFuel_Click(object sender, EventArgs e)
        {
            
        }
        private void textboxMileage_Click(object sender, EventArgs e)
        {

        }
        private void comboColor_Click(object sender, EventArgs e)
        {
            
        }
        private void textboxLicense_Click(object sender, EventArgs e)
        {

        }
        private void textboxVin_Click(object sender, EventArgs e)
        {

        }

    }
}
