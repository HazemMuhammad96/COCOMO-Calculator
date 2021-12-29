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
    public partial class Result : KryptonForm
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            EffortResult.Text = Step1.EI;
            TDEVResult.Text = Step2.TDEV;
            KOLC_Value.Text = Step1.KOLC;
            ActualEffortResult.Text = Step2.AEffort;

            float ei = float.Parse(Step1.EI);
            float aeffort = float.Parse(Step2.AEffort);
            float tdev = float.Parse(Step2.TDEV);

            EffortResultRounded.Text = Math.Round(ei) + "";
            TDEVResultRounded.Text = Math.Round(tdev) + "";
            ActualEffortResultRounded.Text = Math.Round(aeffort) + "";


        }


    }
}
