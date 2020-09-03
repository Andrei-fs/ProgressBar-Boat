using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoShipGraphical
{
    public partial class Form1 : Form
    {
        Ship ship = new Ship();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            updateUI();
           
        }

        private void updateUI()
        {
            //set all of the controls to match the ship props
            progressBar1.Maximum = ship.Capacity;
            if (ship.GetShipLoad() <=ship.Capacity)
            {
                progressBar1.Value = ship.GetShipLoad();
            }

            label_shipLabel.Text = ship.ToString();



            // label numbering

            //motorcycles 
            label_CycleCount.Text = ship.CycleCount.ToString();
            //cars
            label_CarCount.Text = ship.CarCount.ToString();
            //trucks
            label_TruckCount.Text = ship.TruckCount.ToString();
            //trains
            label_TrainCount.Text = ship.TrainCarCount.ToString();

            //progress bar

            if (ship.OverUnder()==0)
            {
                progressBar1.ForeColor = Color.Green;
                label3.Visible = false;

            }
            if (ship.OverUnder()>0)
            {
                progressBar1.ForeColor = Color.DarkOrange;
                label3.Visible = false;
            }

            if (ship.OverUnder()<0)
            {
                progressBar1.ForeColor = Color.Red;
                label3.Text = "Boat overloaded! ";
                label3.Visible = true;

            }
        }

        private void track_motorCycles_Scroll(object sender, EventArgs e)
        {
            ship.CycleCount = track_motorCycles.Value;
            updateUI();
        }

        private void track_Cars_Scroll(object sender, EventArgs e)
        {
            ship.CarCount = track_Cars.Value;
            updateUI();
        }

        private void track_Trucks_Scroll(object sender, EventArgs e)
        {
            ship.TruckCount = track_Trucks.Value;
            updateUI();
        }

        private void track_Trains_Scroll(object sender, EventArgs e)
        {
            ship.TrainCarCount = track_Trains.Value;
            updateUI();
        }
    }
}
