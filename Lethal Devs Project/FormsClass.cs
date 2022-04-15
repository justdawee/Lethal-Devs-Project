using Lethal_Devs_Project.MainFormTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lethal_Devs_Project
{
    class FormsClass
    {
        public static FirstTab firstform = new FirstTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public static SecondTab secondform = new SecondTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public static ThirdTab thirdform = new ThirdTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public static FourthTab fourthform = new FourthTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public static BottomTab bottomform = new BottomTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
    }
}
