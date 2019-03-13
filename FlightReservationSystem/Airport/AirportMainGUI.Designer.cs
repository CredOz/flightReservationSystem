namespace FlightReservationSystem.Airport
{
    partial class AirportMainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.airportAddButton = new System.Windows.Forms.Button();
            this.airportUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // airportAddButton
            // 
            this.airportAddButton.Location = new System.Drawing.Point(221, 63);
            this.airportAddButton.Name = "airportAddButton";
            this.airportAddButton.Size = new System.Drawing.Size(279, 59);
            this.airportAddButton.TabIndex = 0;
            this.airportAddButton.Text = "New Airport";
            this.airportAddButton.UseVisualStyleBackColor = true;
            this.airportAddButton.Click += new System.EventHandler(this.airportAddButton_Click);
            // 
            // airportUpdateButton
            // 
            this.airportUpdateButton.Location = new System.Drawing.Point(221, 170);
            this.airportUpdateButton.Name = "airportUpdateButton";
            this.airportUpdateButton.Size = new System.Drawing.Size(279, 57);
            this.airportUpdateButton.TabIndex = 1;
            this.airportUpdateButton.Text = "button1";
            this.airportUpdateButton.UseVisualStyleBackColor = true;
            this.airportUpdateButton.Click += new System.EventHandler(this.airportUpdateButton_Click);
            // 
            // AirportMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 486);
            this.Controls.Add(this.airportUpdateButton);
            this.Controls.Add(this.airportAddButton);
            this.Name = "AirportMainGUI";
            this.Text = "Airport Management";
            this.Load += new System.EventHandler(this.AirportMainGUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button airportAddButton;
        private System.Windows.Forms.Button airportUpdateButton;
    }
}