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
        private string type;
        private int prodyear;
        private string vin;
        private string license;
        private string color;
        private string mileage;
        private string engine;
        private int ccm;
        private string fueltype;
        private DateTime added;
        private int active;

        public List<string> VehColors = new List<string>
        {
                    "Fehér",
                    "Fekete",
                    "Szürke",
                    "Ezüst",
                    "Kék",
                    "Piros",
                    "Zöld",
                    "Sárga",
                    "Barna",
                    "Lila",
                    "Rózsaszín",
                    "Narancssárga"
        };

        public List<string> Engines = new List<string>
        {
                    "1CYL",
                    "I2",
                    "I3",
                    "I4",
                    "I6",
                    "V2",
                    "W4",
                    "V3",
                    "V4",
                    "V6",
                    "VR5",
                    "VR6",
                    "V8",
                    "W8",
                    "V10",
                    "V12",
                    "W12",
                    "V16",
                    "Wankel",
                    "Electric",
                    "Egyéb"
        };

        public List<string> Fueltypes = new List<string>
        {
                    "Benzin",
                    "Dízel",
                    "Elektromos",
                    "Benzin + Gáz",
                    "Hibrid (Benzin)",
                    "Hibrid (Dízel)",
                    "Hidrogéncella",
                    "Egyéb",
        };

        private int selectedVehIndex;

        private static readonly Vehicles _vehicles = new Vehicles();

        public static Vehicles VehiclesInstance
        {
            get { return _vehicles; }
        }

        public int Id { get => id; set => id = value; }
        public string Owner { get => owner; set => owner = value; }
        public string Type { get => type; set => type = value; }
        public int Prodyear { get => prodyear; set => prodyear = value; }
        public string Vin { get => vin; set => vin = value; }
        public string License { get => license; set => license = value; }
        public string Color { get => color; set => color = value; }
        public string Mileage { get => mileage; set => mileage = value; }
        public string Engine { get => engine; set => engine = value; }
        public int Ccm { get => ccm; set => ccm = value; }
        public string Fueltype { get => fueltype; set => fueltype = value; }
        public DateTime Added { get => added; set => added = value; }
        public int Active { get => active; set => active = value; }
        public int SelectedVehIndex { get => selectedVehIndex; set => selectedVehIndex = value; }
    }
}
