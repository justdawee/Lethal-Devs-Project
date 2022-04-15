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

namespace Lethal_Devs_Project.MainFormTabs
{
    public partial class SecondTab : Form
    {
        SqlConnection conn = new SqlConnection();
        addVehForm vehForm = new addVehForm();
        editVehForm editForm = new editVehForm();

        Vehicles veh = new Vehicles();

        public SecondTab()
        {
            InitializeComponent();
        }

        private void addVehBtn_Click(object sender, EventArgs e)
        {
            vehForm.ShowDialog();
        }
        private void editVehBtn_Click(object sender, EventArgs e)
        {
            editForm.ShowDialog();
        }
        private void delVehBtn_Click(object sender, EventArgs e)
        {

        }

        private void SecondTab_Load(object sender, EventArgs e)
        {
            FormsClass.secondform = this;
            refreshList();
        }

        public void refreshList()
        {
            if (conn.checkEmptyTable("vehicles") == false)
            {
                listVehicles.Items.Clear();
                var vehicles = conn.getVehicleTable();
                foreach (var vehicle in vehicles)
                {
                    var format = $"(ID: {vehicle.Id}) {vehicle.Prodyear} {vehicle.Type} > Tulaj: {vehicle.Owner} [Motor: {vehicle.Engine}, cm3: {vehicle.Ccm}, Üzemanyag: {vehicle.Fueltype}, Szín: {vehicle.Color}, Futásadat: {vehicle.Mileage}, Rendszám: {vehicle.License}, Alvázszám: {vehicle.Vin}, Hozzáadva: {vehicle.Added}, Aktív: {vehicle.Active}";
                    listVehicles.Items.Add(format);
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refreshList();
        }
    }
}
