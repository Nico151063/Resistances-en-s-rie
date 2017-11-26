using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSerie
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btCalcul_Click(object sender, EventArgs e)
        {

            float volts = float.Parse(edVolts.Text);
            float R1 = float.Parse(edR1.Text);
            float R2 = float.Parse(edR2.Text);
            float resistanceGlobale = R1 + R2;

            //Calcul du i
            float courant = volts / resistanceGlobale;
            lbCourant.Text = courant.ToString("0.0000000");

            string infoCourant = "i = U/R";
            infoCourant += " = " + volts.ToString("0.0") + " / (" + R1.ToString("0") + "+" + R2.ToString("0") + ")";
            infoCourant += " = " + volts.ToString("0.0") + " / " + resistanceGlobale.ToString("0");
            infoCourant += " = " + (volts/resistanceGlobale).ToString("0.0000000");
            infoCourant += " Amp";
            lbInfoCourant.Text = infoCourant;

            //Calcul V1
            float v1 = R1 * courant;
            lbV1.Text = v1.ToString("0.00");

            string infoV1 = "V1 = R1 * i";
            infoV1 += " = " +  R1.ToString("0") + " * " + courant.ToString("0.0000000");
            infoV1 += " Volts";
            lbInfoV1.Text = infoV1;

            
            //Calcul V2
            float v2 = R2 * courant;
            lbV2.Text = v2.ToString("0.00");

            string infoV2 = "V2 = R2 * i";
            infoV2 += " = " + R2.ToString("0") + " * " + courant.ToString("0.0000000");
            infoV2 += " Volts";
            lbInfoV2.Text = infoV2;

            //V1+V2
            float V1V2 = v1 + v2;
            lbV1V2.Text = V1V2.ToString("0.00");

            string infoV1V2 = "Delta V = V - (V1+V2)";
            infoV1V2 += " = " + (volts-V1V2).ToString("0.0000");
            lbInfoV1V2.Text = infoV1V2;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = "Resistances en sérise";
        }
    }
}
