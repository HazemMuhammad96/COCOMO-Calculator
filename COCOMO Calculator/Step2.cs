using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace COCOMO_Calculator
{
    public partial class Step2 : KryptonForm
    {
        public static string AEffort = "";
        public static string TDEV = "";

        Dictionary<CostDrivers, string> map = new Dictionary<CostDrivers, string>();
        public Dictionary<string, string> values = new Dictionary<string, string>() {
                { "Very Low", "vl" },
                { "Low", "l" },
                { "Nominal", "n" },
                { "High", "h" },
                { "Very High", "vh" },
                {"Extra High", "eh" },
            };
        public Step2()
        {
            InitializeComponent();
        }

        private void Step2_Load(object sender, EventArgs e)
        {

        }

        private void onComboBoxSelect(CostDrivers driver, string value)
        {
            if (value == "" || value == null) return;

            map.Add(driver, values[value]);

        }

        private void CalcActualEffort_Click(object sender, EventArgs e)
        {
            map.Clear();
            

            // Product Attr
            onComboBoxSelect(CostDrivers.REQUIRED_SOFTWARE_RELIABILITY, (string)Product1.SelectedItem);
            onComboBoxSelect(CostDrivers.SIZE_OF_APP_DATABASE, (string)Product2.SelectedItem);
            onComboBoxSelect(CostDrivers.COMPLEXITY_OF_PRODUCT, (string)Product3.SelectedItem);

            // Hardware Attr
            onComboBoxSelect(CostDrivers.RUNTIME_PERFOMANCE_CONSTRAINTS, (string)Hardware1.SelectedItem);
            onComboBoxSelect(CostDrivers.MEMORY_CONSTRAINTS, (string)Hardware2.SelectedItem);
            onComboBoxSelect(CostDrivers.VOLATILITY_OF_VM_ENV, (string)Hardware3.SelectedItem);
            onComboBoxSelect(CostDrivers.REQUIRED_TURNABOUT_TIME, (string)Hardware4.SelectedItem);

            // Personnal Attr
            onComboBoxSelect(CostDrivers.ANALYST_CAPABILITY, (string)Personnel1.SelectedItem);
            onComboBoxSelect(CostDrivers.APP_EXPERIENCE, (string)Personnel2.SelectedItem);
            onComboBoxSelect(CostDrivers.SWE_CAPABILITY, (string)Personnel3.SelectedItem);
            onComboBoxSelect(CostDrivers.VM_EXPERIENCE, (string)Personnel4.SelectedItem);
            onComboBoxSelect(CostDrivers.PROGLANG_EXPERIENCE, (string)Personnel5.SelectedItem);

            //Project Attr
            onComboBoxSelect(CostDrivers.APP_OF_SWE_METHODS, (string)Project1.SelectedItem);
            onComboBoxSelect(CostDrivers.USE_OF_SW_TOOLS, (string)Project2.SelectedItem);
            onComboBoxSelect(CostDrivers.REQUIRED_DEV_SCHEDULE, (string)Project3.SelectedItem);


            int Cvalue = int.Parse(Step1.KOLC);
            CocomoCalculator c = new CocomoCalculator(Cvalue);
            float ei = float.Parse(Step1.EI);
            c.SetEI(ei);
            c.initStep2(map);

            ActualEffort.Text = c.GetEFinal().ToString();
            TDEV = c.GetTDEV()+"";

 
        }

        private void NextStep_Click(object sender, EventArgs e)
        {
            AEffort = ActualEffort.Text;

            this.Hide();
            Result R = new Result();
            R.ShowDialog();
            this.Close();
        }


    }
}
