using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lethal_Devs_Project
{
    internal class Statistics
    {
        private int dbsize;
        private int querycount;
        private double avgmileage;
        private int carscount;
        private int usercount;
        private string biggestvehicles;
        private string mostcarowner;

        private static readonly Statistics _stat = new Statistics();
        public static Statistics StatInstance
        {
            get { return _stat; }
        }

        public int Dbsize { get => dbsize; set => dbsize = value; }
        public int Querycount { get => querycount; set => querycount = value; }
        public double Avgmileage { get => avgmileage; set => avgmileage = value; }
        public int Carscount { get => carscount; set => carscount = value; }
        public int Usercount { get => usercount; set => usercount = value; }
        public string Biggestvehicles { get => biggestvehicles; set => biggestvehicles = value; }
        public string Mostcarowner { get => mostcarowner; set => mostcarowner = value; }

    }
}
