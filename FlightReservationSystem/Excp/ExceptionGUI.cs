using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlightReservationSystem.Excp
{
    public partial class ExceptionGUI : Form
    {
        public ExceptionGUI(String message)
        {
            InitializeComponent();
            excpLbl.Text = message;
        }

        private void ExceptionGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
