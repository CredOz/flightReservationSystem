using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using FlightReservationSystem.Excp; 

namespace FlightReservationSystem.Airport
{
    public partial class AirportUpdateGUI : Form
    {
        private OracleConnection conn;
        public AirportUpdateGUI()
        {
            InitializeComponent();
            nameLbl.Text = "Name :";
            airportIdLbl.Text = "Airport ID :";
            cityLbl.Text = "City :";
            countryLbl.Text = "Country :";
            statusLbl.Text = "Airport Status :";
            airportAddSaveButton.Text = "Save";
            cancelButton.Text = "Cancel";
            selectAirportLbl.Text = "Select the Airport to Update";
            try
            {
                string oradb = "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = CMBTRNDB01)(PORT = 1521)) (CONNECT_DATA = (SID = APP9))); User Id = ifsapp; Password = ifsapp";
                conn = new OracleConnection(oradb);  // C#
                conn.Open();
            }
            catch (Exception er)
            {
                Form frm = new ExceptionGUI(er.Message);
                frm.Show();
            }
        }

        public ~AirportUpdateGUI()
        {
            conn.Dispose();
        }

        private void updateTextBoxes(string id, string name, string city, string country, string status)
        {
            nameTxt.Text = name;
            cityTxt.Text = city;
            countryTxt.Text = country;
            statusTxt.Text = status;
            airportIdTxt.Text = id;
        }

        private void resetTextBoxes()
        {
            nameTxt.Text = "";
            cityTxt.Text = "";
            countryTxt.Text = "";
            statusTxt.Text = "";
            airportIdTxt.Text = "";
        }
        private void AirportUpdateGUI_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
