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



    public partial class Step1 : KryptonForm
    {
        public static string EI = "";
        public static string TDEV = "";
        public static string KOLC = "";
        public Step1()
        {
            InitializeComponent();
        }

        private void Step1_Load(object sender, EventArgs e)
        {

        }

        private void NextStep_Click(object sender, EventArgs e)
        {
            EI = EffortResult.Text;
            TDEV = TDEVResult.Text;
            KOLC = KOLC_Value.Text;

            this.Hide();
            Step2 S2 = new Step2();
            S2.ShowDialog();
            this.Close();
        }

        private void EffortCalculate_Click(object sender, EventArgs e)
        {
            string Text = KOLC_Value.Text;
            int Cvalue = int.Parse(Text);
            CocomoCalculator c = new CocomoCalculator(Cvalue);
            c.overrideUsedModel((String)ProjectType.SelectedItem);
            c.initStep1();
            EffortResult.Text = c.GetEI().ToString();
        }

        private void TDEV_Calculate_Click(object sender, EventArgs e)
        {
            string Text = KOLC_Value.Text;
            int Cvalue = int.Parse(Text);
            CocomoCalculator c = new CocomoCalculator(Cvalue);
            c.overrideUsedModel((String)ProjectType.SelectedItem);
            c.initStep1();
            TDEVResult.Text = c.GetTDEV().ToString();
        }
    }
}
