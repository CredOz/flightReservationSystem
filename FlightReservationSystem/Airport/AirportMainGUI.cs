using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlightReservationSystem.Airport
{
    public partial class AirportMainGUI : Form
    {
        public AirportMainGUI()
        {
            InitializeComponent();
            airportUpdateButton.Text = "Update Airport";
        }

        private void AirportMainGUI_Load(object sender, EventArgs e)
        {

        }

        private void airportAddButton_Click(object sender, EventArgs e)
        {
            Form frm = new AirportAddGUI();
            frm.Show();
        }

        private void airportUpdateButton_Click(object sender, EventArgs e)
        {
            Form frm = new AirportUpdateGUI();
            frm.Show();
        }
    }
}
