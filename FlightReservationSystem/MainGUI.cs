using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlightReservationSystem.Airport;

namespace FlightReservationSystem
{
    public partial class mainGUI : Form
    {
        public mainGUI()
        {
            InitializeComponent();
        }

        private void airportButton_Click(object sender, EventArgs e)
        {
            Form frm = new AirportMainGUI();
            frm.Show();
        }
    }
}
