﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
            Application.EnableVisualStyles();
            usersGoal();
        }

        private void FirstTab_Load(object sender, EventArgs e)
        {
            FormsClass.firstform = this;
            NumberOfVehicles();
            BiggestEngineVehicles();
            AverageMiles();
            UserCount();
            MostCars();
            usersGoal();
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
        private void UserCount()
        {
            if (conn.checkEmptyTable("users") == false)
            {
                var number = 0;
                var users = conn.getUsersTable();
                foreach (var user in users)
                {
                    number++;
                }
                lblUserCount.Text = $"{number} db";
            }
        }
        private void MostCars()
        {
            var owner = "";
            var ownednumber = 0;
            var number = 0;
            if (conn.checkEmptyTable("vehicles") == false)
            {
                var listmostcars = new List<string>();
                
                var vehicles = conn.getVehicleTable();
                var sorted = vehicles.OrderByDescending(x => x.Owner)
                                     .ThenBy(x => x.Owner)
                                     .ToList();

                foreach (var vehicle in sorted)
                {
                    if (vehicle.Owner == vehicle.Owner)
                    {
                        ownednumber++;
                        owner = vehicle.Owner;
                    }
                    number++;
                    var format = $"#{number}: {vehicle.Prodyear} {vehicle.Type} {vehicle.Engine} {vehicle.Ccm} cm3 [Tulaj: {vehicle.Owner}]";
                    listmostcars.Add(format);
                }

                lblMostCars.Text = $"{owner} ~ {ownednumber} db";
            }
            
            
        }

        private void usersGoal()
        {
            double number = 0;
            double goalusers = 100;
            if (conn.checkEmptyTable("users") == false)
            {
                var users = conn.getUsersTable();
                foreach (var user in users)
                {
                    number++;
                }   
            }

            for (int i = 0; i < number; i++)
            {
                progressBar.Value = i;
                progressBar.Maximum = (int)goalusers;
                progressBar.PerformStep();
                progressBar.Update();
            }
            double percent = number / goalusers * 100;
            progressBar.Text = $"{percent}%";
            lblProgressBar.Text = $"{number}/{goalusers}db felhasználó.\nSzükséges még: {goalusers-number} db felhasználó.\nAz elmúlt 28 nap adatai";

        }

    }
}
