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
        public Step2()
        {
            InitializeComponent();
        }

        private void CalcActualEffort_Click(object sender, EventArgs e)
        {
            Dictionary<CostDrivers, string> map = new Dictionary<CostDrivers, string>();

            // Product Attr
            //REQUIRED_SOFTWARE_RELIABILITY
            if ((String)Product1.SelectedItem == "Very Low")
                map.Add(CostDrivers.REQUIRED_SOFTWARE_RELIABILITY, "vl");
            else if ((String)Product1.SelectedItem == "Low")
                map.Add(CostDrivers.REQUIRED_SOFTWARE_RELIABILITY, "l");
            else if ((String)Product1.SelectedItem == "Nominal")
                map.Add(CostDrivers.REQUIRED_SOFTWARE_RELIABILITY, "n");
            else if ((String)Product1.SelectedItem == "High")
                map.Add(CostDrivers.REQUIRED_SOFTWARE_RELIABILITY, "h");
            else if ((String)Product1.SelectedItem == "Very High")
                map.Add(CostDrivers.REQUIRED_SOFTWARE_RELIABILITY, "vh");

            //SIZE_OF_APP_DATABASE
            else if ((String)Product2.SelectedItem == "Low")
                map.Add(CostDrivers.SIZE_OF_APP_DATABASE, "l");
            else if ((String)Product2.SelectedItem == "Nominal")
                map.Add(CostDrivers.SIZE_OF_APP_DATABASE, "n");
            else if ((String)Product2.SelectedItem == "High")
                map.Add(CostDrivers.SIZE_OF_APP_DATABASE, "h");
            else if ((String)Product2.SelectedItem == "Very High")
                map.Add(CostDrivers.SIZE_OF_APP_DATABASE, "vh");

            //COMPLEXITY_OF_PRODUCT
            if ((String)Product3.SelectedItem == "Very Low")
                map.Add(CostDrivers.COMPLEXITY_OF_PRODUCT, "vl");
            else if ((String)Product3.SelectedItem == "Low")
                map.Add(CostDrivers.COMPLEXITY_OF_PRODUCT, "l");
            else if ((String)Product3.SelectedItem == "Nominal")
                map.Add(CostDrivers.COMPLEXITY_OF_PRODUCT, "n");
            else if ((String)Product3.SelectedItem == "High")
                map.Add(CostDrivers.COMPLEXITY_OF_PRODUCT, "h");
            else if ((String)Product3.SelectedItem == "Very High")
                map.Add(CostDrivers.COMPLEXITY_OF_PRODUCT, "vh");
            else if ((String)Product3.SelectedItem == "Extra High")
                map.Add(CostDrivers.COMPLEXITY_OF_PRODUCT, "eh");

            // Hardware Attr
            //RUNTIME_PERFOMANCE_CONSTRAINTS
            else if ((String)Hardware1.SelectedItem == "Nominal")
                map.Add(CostDrivers.RUNTIME_PERFOMANCE_CONSTRAINTS, "n");
            else if ((String)Hardware1.SelectedItem == "High")
                map.Add(CostDrivers.RUNTIME_PERFOMANCE_CONSTRAINTS, "h");
            else if ((String)Hardware1.SelectedItem == "Very High")
                map.Add(CostDrivers.RUNTIME_PERFOMANCE_CONSTRAINTS, "vh");
            else if ((String)Hardware1.SelectedItem == "Extra High")
                map.Add(CostDrivers.RUNTIME_PERFOMANCE_CONSTRAINTS, "eh");

            //MEMORY_CONSTRAINTS
            else if ((String)Hardware2.SelectedItem == "Nominal")
                map.Add(CostDrivers.MEMORY_CONSTRAINTS, "n");
            else if ((String)Hardware2.SelectedItem == "High")
                map.Add(CostDrivers.MEMORY_CONSTRAINTS, "h");
            else if ((String)Hardware2.SelectedItem == "Very High")
                map.Add(CostDrivers.MEMORY_CONSTRAINTS, "vh");
            else if ((String)Hardware2.SelectedItem == "Extra High")
                map.Add(CostDrivers.MEMORY_CONSTRAINTS, "eh");

            //VOLATILITY_OF_VM_ENV
            else if ((String)Hardware3.SelectedItem == "Low")
                map.Add(CostDrivers.VOLATILITY_OF_VM_ENV, "l");
            else if ((String)Hardware3.SelectedItem == "Nominal")
                map.Add(CostDrivers.VOLATILITY_OF_VM_ENV, "n");
            else if ((String)Hardware3.SelectedItem == "High")
                map.Add(CostDrivers.VOLATILITY_OF_VM_ENV, "h");
            else if ((String)Hardware3.SelectedItem == "Very High")
                map.Add(CostDrivers.VOLATILITY_OF_VM_ENV, "vh");

            //REQUIRED_TURNABOUT_TIME
            else if ((String)Hardware4.SelectedItem == "Low")
                map.Add(CostDrivers.REQUIRED_TURNABOUT_TIME, "l");
            else if ((String)Hardware4.SelectedItem == "Nominal")
                map.Add(CostDrivers.REQUIRED_TURNABOUT_TIME, "n");
            else if ((String)Hardware4.SelectedItem == "High")
                map.Add(CostDrivers.REQUIRED_TURNABOUT_TIME, "h");
            else if ((String)Hardware4.SelectedItem == "Very High")
                map.Add(CostDrivers.REQUIRED_TURNABOUT_TIME, "vh");

            // Personnal Attr
            //ANALYST_CAPABILITY
            if ((String)Personnel1.SelectedItem == "Very Low")
                map.Add(CostDrivers.ANALYST_CAPABILITY, "vl");
            else if ((String)Personnel1.SelectedItem == "Low")
                map.Add(CostDrivers.ANALYST_CAPABILITY, "l");
            else if ((String)Personnel1.SelectedItem == "Nominal")
                map.Add(CostDrivers.ANALYST_CAPABILITY, "n");
            else if ((String)Personnel1.SelectedItem == "High")
                map.Add(CostDrivers.ANALYST_CAPABILITY, "h");
            else if ((String)Personnel1.SelectedItem == "Very High")
                map.Add(CostDrivers.ANALYST_CAPABILITY, "vh");

            //APP_EXPERIENCE
            if ((String)Personnel2.SelectedItem == "Very Low")
                map.Add(CostDrivers.APP_EXPERIENCE, "vl");
            else if ((String)Personnel2.SelectedItem == "Low")
                map.Add(CostDrivers.APP_EXPERIENCE, "l");
            else if ((String)Personnel2.SelectedItem == "Nominal")
                map.Add(CostDrivers.APP_EXPERIENCE, "n");
            else if ((String)Personnel2.SelectedItem == "High")
                map.Add(CostDrivers.APP_EXPERIENCE, "h");
            else if ((String)Personnel2.SelectedItem == "Very High")
                map.Add(CostDrivers.APP_EXPERIENCE, "vh");

            //SWE_CAPABILITY
            if ((String)Personnel3.SelectedItem == "Very Low")
                map.Add(CostDrivers.SWE_CAPABILITY, "vl");
            else if ((String)Personnel3.SelectedItem == "Low")
                map.Add(CostDrivers.SWE_CAPABILITY, "l");
            else if ((String)Personnel3.SelectedItem == "Nominal")
                map.Add(CostDrivers.SWE_CAPABILITY, "n");
            else if ((String)Personnel3.SelectedItem == "High")
                map.Add(CostDrivers.SWE_CAPABILITY, "h");
            else if ((String)Personnel3.SelectedItem == "Very High")
                map.Add(CostDrivers.SWE_CAPABILITY, "vh");

            //VM_EXPERIENCE
            if ((String)Personnel4.SelectedItem == "Very Low")
                map.Add(CostDrivers.VM_EXPERIENCE, "vl");
            else if ((String)Personnel4.SelectedItem == "Low")
                map.Add(CostDrivers.VM_EXPERIENCE, "l");
            else if ((String)Personnel4.SelectedItem == "Nominal")
                map.Add(CostDrivers.VM_EXPERIENCE, "n");
            else if ((String)Personnel4.SelectedItem == "High")
                map.Add(CostDrivers.VM_EXPERIENCE, "h");

            //PROGLANG_EXPERIENCE
            if ((String)Personnel5.SelectedItem == "Very Low")
                map.Add(CostDrivers.PROGLANG_EXPERIENCE, "vl");
            else if ((String)Personnel5.SelectedItem == "Low")
                map.Add(CostDrivers.PROGLANG_EXPERIENCE, "l");
            else if ((String)Personnel5.SelectedItem == "Nominal")
                map.Add(CostDrivers.PROGLANG_EXPERIENCE, "n");
            else if ((String)Personnel5.SelectedItem == "High")
                map.Add(CostDrivers.PROGLANG_EXPERIENCE, "h");

            //Project Attr
            //APP_OF_SWE_METHODS
            if ((String)Project1.SelectedItem == "Very Low")
                map.Add(CostDrivers.APP_OF_SWE_METHODS, "vl");
            else if ((String)Project1.SelectedItem == "Low")
                map.Add(CostDrivers.APP_OF_SWE_METHODS, "l");
            else if ((String)Project1.SelectedItem == "Nominal")
                map.Add(CostDrivers.APP_OF_SWE_METHODS, "n");
            else if ((String)Project1.SelectedItem == "High")
                map.Add(CostDrivers.APP_OF_SWE_METHODS, "h");
            else if ((String)Project1.SelectedItem == "Very High")
                map.Add(CostDrivers.APP_OF_SWE_METHODS, "vh");

            //USE_OF_SW_TOOLS
            if ((String)Project2.SelectedItem == "Very Low")
                map.Add(CostDrivers.USE_OF_SW_TOOLS, "vl");
            else if ((String)Project2.SelectedItem == "Low")
                map.Add(CostDrivers.USE_OF_SW_TOOLS, "l");
            else if ((String)Project2.SelectedItem == "Nominal")
                map.Add(CostDrivers.USE_OF_SW_TOOLS, "n");
            else if ((String)Project2.SelectedItem == "High")
                map.Add(CostDrivers.USE_OF_SW_TOOLS, "h");
            else if ((String)Project2.SelectedItem == "Very High")
                map.Add(CostDrivers.USE_OF_SW_TOOLS, "vh");

            //REQUIRED_DEV_SCHEDULE
            if ((String)Project3.SelectedItem == "Very Low")
                map.Add(CostDrivers.REQUIRED_DEV_SCHEDULE, "vl");
            else if ((String)Project3.SelectedItem == "Low")
                map.Add(CostDrivers.REQUIRED_DEV_SCHEDULE, "l");
            else if ((String)Project3.SelectedItem == "Nominal")
                map.Add(CostDrivers.REQUIRED_DEV_SCHEDULE, "n");
            else if ((String)Project3.SelectedItem == "High")
                map.Add(CostDrivers.REQUIRED_DEV_SCHEDULE, "h");
            else if ((String)Project3.SelectedItem == "Very High")
                map.Add(CostDrivers.REQUIRED_DEV_SCHEDULE, "vh");

            int Cvalue = int.Parse(Step1.KOLC);
            CocomoCalculator c = new CocomoCalculator(Cvalue);
            float ei = float.Parse(Step1.EI);
            c.SetEI(ei);
            c.initStep2(map);

            ActualEffort.Text = c.GetEFinal().ToString();


 
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
