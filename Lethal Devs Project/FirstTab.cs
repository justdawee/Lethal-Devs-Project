using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lethal_Devs_Project
{
    public partial class FirstTab : Form
    {
        SqlConnection conn = new SqlConnection();

        public FirstTab()
        {
            InitializeComponent();
        }

        private void FirstTab_Load(object sender, EventArgs e)
        {
            FormsClass.firstform = this;
            NumberOfVehicles();
            BiggestEngineVehicles();
            AverageMiles();
            if (conn.checkEmptyTable("vehicles") == false)
            {
                listBiggestEngines.SelectedIndex = 0;
            }
        }

        private void BiggestEngineVehicles()
        {
            if (conn.checkEmptyTable("vehicles") == false)
            {
                listBiggestEngines.Items.Clear();
                var number = 0;
                var vehicles = conn.getVehicleTable();
                var sorted = vehicles.OrderByDescending(x => x.Ccm)
                                     .ThenBy(x => x.Ccm)
                                     .ToList();
                foreach (var vehicle in sorted)
                {
                    number++;
                    var format = $"#{number}: {vehicle.Prodyear} {vehicle.Type} {vehicle.Engine} {vehicle.Ccm} cm3 [Tulaj: {vehicle.Owner}]";
                    listBiggestEngines.Items.Add(format);
                }
            }
        }
        private void AverageMiles()
        {
            if (conn.checkEmptyTable("vehicles") == false)
            {
                double allmiles = 0;
                double numberofcars = 0;
                double avg = 0;
                var vehicles = conn.getVehicleTable();
                foreach (var vehicle in vehicles)
                {
                    numberofcars++;
                    allmiles += Convert.ToInt32(vehicle.Mileage);
                }
                avg = allmiles / numberofcars;
                var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                nfi.NumberGroupSeparator = " ";
                var formatted = avg.ToString("#,0", nfi); // "1 234 897"

                lblAvgMileage.Text = $"{formatted} km";
            }
        }
        private void NumberOfVehicles()
        {
            if (conn.checkEmptyTable("vehicles") == false)
            {
                var number = 0;
                var vehicles = conn.getVehicleTable();
                foreach (var vehicle in vehicles)
                {
                    number++;
                }
                lblNumOfVehicles.Text = $"{number} db";
            }
        }
    }
}
