// Zach Palmer Heart Rate Calculator

/*
 *  THR is calculated by 220 - age 
 *  I tested age against 30 then applied corresponding formula
 *  the program follows the specifications from the word doc
 *  I also did the extra work with trackbar
 *  the trackbar will move to the calculated THR then display info about that zone
 *  if you move the slide trackbar then it calculates your heart rate base off the lowest point for that zone 
 *  then displays zone information and users THR for that zone
 */

// 9/5/2021 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palmer_TargetHeartRateCalculator
{
    public partial class Form1 : Form
    {
        private int age = 0;
        private int bpm = 0;
        private string errorMsg = String.Empty;
        private string[] zoneMsgs = { 
            "50 - 60%\nDevelops endurance and aerobic capacity\nGreat for burning fat",
            "60 - 70%\nIdeal Training Zone\nGreat for cardio\nHelps make muscles stronger",
            "70 - 80%\nEnhances aerobic power\nImproves blood circulation",
            "80 - 90%\nBody develops ability to handle lactic acid\nImproves high speed endurance",
            "90 -100%\nTones Neuromuscular System\nIncrease maximum race sprint speed"
        };
        

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //populate  activity type combobox at load
            activityCmbx.Items.Add("--Select an Activity--");
            activityCmbx.Items.Add("Moderate");
            activityCmbx.Items.Add("Vigorous");
            activityCmbx.SelectedIndex = 0;

            // set form default size
            this.Size = new Size(816, 393);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clear btn logic
            ageTxt.Text = String.Empty;
            activityCmbx.SelectedIndex = 0;
            statsListview.Items.Clear();
            zoneTbar.Value = zoneTbar.Minimum;
            zoneInfoLbl.Text = String.Empty;
            heartzoneLbl.Text = String.Empty;
            zoneChbx.Checked = false;
            ageTxt.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Exit btn logic
            this.Close();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            int zonelo = 0;
            int zonehi = 0;
            string activityType = String.Empty;

            // get data from form input then validate
            bool valid = validateForm();
            if (valid)
            {
                age = Convert.ToInt32(ageTxt.Text);

                activityType = activityCmbx.SelectedItem.ToString();

                // use THR class to calculate zone values
                TargetHeartRate thr = new TargetHeartRate(age);
                bpm = thr.THR;

                // determine activity type and heart rate zone bounds
                switch (activityType)
                {
                    case "Moderate":
                        zonelo = thr.ModLow;
                        zonehi = thr.ModHigh;
                        break;
                    case "Vigorous":
                        zonelo = thr.VigLow;
                        zonehi = thr.VigHigh;
                        break;
                }

                // add zone stats to listview
                statsListview.Items.Clear();
                statsListview.Items.Add(age.ToString());
                statsListview.Items[0].SubItems.Add(bpm.ToString());
                statsListview.Items[0].SubItems.Add(activityType);
                statsListview.Items[0].SubItems.Add(zonelo.ToString() + " to " + zonehi.ToString() + " beats per minute");

                // if training zone selected then display slider on zone
                if (zoneChbx.Checked)
                {
                    switch (activityType)
                    {
                        case "Moderate":
                            zoneTbar.Value = 61;
                            zoneInfoLbl.Text = "50-70%\nFat Burning and Aerobic Zones\nDevelops Endurance\nGreat for cardio";
                            break;
                        case "Vigorous":
                            zoneTbar.Value = 81;
                            zoneInfoLbl.Text = 
                                "70-85%\nSteady State and Anaerobic Zones\nEnhances aerobic power\nImprove high speed endurance";
                            break;
                    }
                    heartzoneLbl.Text = zonelo.ToString() + " - " + zonehi.ToString() + "beats per minute";
                }
            }
            else
                MessageBox.Show(errorMsg);             
        }

        private bool validateForm()
        {
            bool valid = true;
            if (String.IsNullOrEmpty(ageTxt.Text))
            { 
                errorMsg = "Error Please Enter Age";
                valid = false;
                ageTxt.Focus();  
            }
                
            else if (!int.TryParse(ageTxt.Text, out int age))
            { 
                errorMsg = "Error Age Must Be Numeric";
                valid = false;
                ageTxt.Focus();
            }
                
            else if (age < 0 || age > 100)
            { 
                errorMsg = "Invalid, Age Must Be Between 1-100";
                valid = false;
                ageTxt.Focus();
            }
                
            else if (activityCmbx.SelectedIndex == 0)
            {
                errorMsg = "Error Must Select Activity Type";
                valid = false;
                activityCmbx.Focus();
            }
            return valid;
        }
        private int getZoneType(int z)
        {
            int zone = -1;

            if (z >= 50 && zoneTbar.Value <= 60)
                zone = 0;
            else if (z >= 61 && zoneTbar.Value <= 70)
                zone = 1;
            else if (z >= 71 && zoneTbar.Value <= 80)
                zone = 2;
            else if (z >= 81 && zoneTbar.Value <= 90)
                zone = 3;
            else if (z >= 91 && zoneTbar.Value <= 100)
                zone = 4;
            return zone;
        }
        private int getZoneBounds(int zone)
        {
            // uses switch to determine zone bounds to to be used to set trackbar
            // zone is pass in after returning from getZoneType method and sets z to mid point of zone
            int z = -1;
            
            switch (zone)
            {
                case 0:
                    z = 55;
                    break;
                case 1:
                    z = 65;
                    break;
                case 2:
                    z = 75;
                    break;
                case 3:
                    z = 85;
                    break;
                case 4:
                    z = 95;
                    break;
            }
            return z;
        }

        private void zoneChbx_CheckedChanged(object sender, EventArgs e)
        {
            switch(zoneChbx.Checked)
            {
                case true:
                    this.Size = new Size(816, 825);
                    break;
                case false:
                    this.Size = new Size(816, 393);
                    break;
            }
        }
        private double[] setLowsAndHighs(int zone)
        {
            double low = -1, high = -1;
            double[] lowAndHigh = new double[2];

            switch (zone)
            {
                case 0:
                    low = .5;
                    high = .6;
                    break;
                case 1:
                    low = .61;
                    high = .7;
                    break;
                case 2:
                    low = .71;
                    high = .8;
                    break;
                case 3:
                    low = .81;
                    high = .9;
                    break;
                case 4:
                    low = .91;
                    high = 1;
                    break;
            }
            lowAndHigh[0] = low;
            lowAndHigh[1] = high;

            return lowAndHigh;
        }
        private void zoneTbar_Scroll(object sender, EventArgs e)
        {
            int z = getZoneType(zoneTbar.Value);
            // returns a technically a tuple for the lo and high values
            double[] bounds = setLowsAndHighs(z);
            string zoneMsg = zoneMsgs[z];


            // calculate THR for zone lows and highs

            double bpmlo = Math.Round((double)bpm * bounds[0], 0, MidpointRounding.AwayFromZero);
            double bpmhi = Math.Round((double)bpm * bounds[1], 0, MidpointRounding.AwayFromZero);

            if (age != 0)
            {
                zoneInfoLbl.Text = zoneMsg;
                heartzoneLbl.Text = bpmlo.ToString() + " - " + bpmhi.ToString() + " (beats per minute)";
            }
                
            else
            {
                zoneInfoLbl.Text = zoneMsg;
                heartzoneLbl.Text = "Your THR is unavialiable";
            }
        }
    }
}
