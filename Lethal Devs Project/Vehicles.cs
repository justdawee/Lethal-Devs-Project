using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lethal_Devs_Project
{
    internal class Vehicles
    {
        private int id;
        private string owner;
        private string manufacturer;
        private string model;
        private string vin;
        private string license;
        private string color;
        private string mileage;
        private string engine;
        private string fueltype;
        private DateTime added;
        private bool active;

        private static readonly Vehicles _vehicles = new Vehicles();

        public static Vehicles VehiclesInstance
        {
            get { return _vehicles; }
        }

        public int Id { get => id; set => id = value; }
        public string Owner { get => owner; set => owner = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Model { get => model; set => model = value; }
        public string Vin { get => vin; set => vin = value; }
        public string License { get => license; set => license = value; }
        public string Color { get => color; set => color = value; }
        public string Mileage { get => mileage; set => mileage = value; }
        public string Engine { get => engine; set => engine = value; }
        public string Fueltype { get => fueltype; set => fueltype = value; }
        public DateTime Added { get => added; set => added = value; }
        public bool Active { get => active; set => active = value; }
    }
}
