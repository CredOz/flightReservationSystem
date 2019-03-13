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
    public partial class AirportAddGUI : Form
    {
        public AirportAddGUI()
        {
            InitializeComponent();
            nameLbl.Text = "Name :";
            airportIdLbl.Text = "Airport ID :";
            cityLbl.Text = "City :";
            countryLbl.Text = "Country :";
            statusLbl.Text = "Airport Status :";
            airportAddSaveButton.Text = "Save";
            cancelButton.Text = "Cancel";
        }

        private void AirportAddGUI_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetTextBoxes()
        {
            nameTxt.Text="";
            cityTxt.Text="";
            countryTxt.Text="";
            statusTxt.Text="";
            airportIdTxt.Text = "";
        }

        private void airportAddSaveButton_Click(object sender, EventArgs e)
        {
            string name, city, country, status;
            int id;
            name = nameTxt.Text;
            city = cityTxt.Text;
            country = countryTxt.Text;
            status = statusTxt.Text;
            int.TryParse(airportIdTxt.Text, out id);
            if (name == "" || city == "" || country == "" || status == "" || id.Equals(null))
            {
                Form frm = new ExceptionGUI("Spaces cannot be unfilled");
                frm.Show();
            }
            else
            {
                try
                {
                    string oradb = "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = CMBTRNDB01)(PORT = 1521)) (CONNECT_DATA = (SID = APP9))); User Id = ifsapp; Password = ifsapp";
                    OracleConnection conn = new OracleConnection(oradb);  // C#
                    conn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "AIRPORT_PKG_DIWCLK_HGAJLK.INSERT_AIRPORT_DIWCLK_HGAJLK";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("airport_id", OracleDbType.Int32).Value = id;
                    cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    cmd.Parameters.Add("city", OracleDbType.Varchar2).Value = city;
                    cmd.Parameters.Add("country", OracleDbType.Varchar2).Value = country;
                    cmd.Parameters.Add("airport_status", OracleDbType.Varchar2).Value = status;
                    //OracleDataReader dr = cmd.ExecuteReader();
                    //dr.Read();
                    //nameTxt.Text = dr.GetString(0);
                    //Console.WriteLine(dr.GetString(0));
                    cmd.ExecuteNonQuery();
                    resetTextBoxes();
                    Form frm = new ExceptionGUI("Airport Successfully Added");
                    frm.Show();
                    conn.Dispose();
                }
                catch (Exception er)
                {
                    Form frm = new ExceptionGUI(er.Message);
                    frm.Show();
                }
            }
           
        }
    }
}
