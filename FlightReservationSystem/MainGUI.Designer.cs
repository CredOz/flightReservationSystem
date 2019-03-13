namespace FlightReservationSystem
{
    partial class mainGUI
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
            this.airportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // airportButton
            // 
            this.airportButton.Location = new System.Drawing.Point(240, 64);
            this.airportButton.Name = "airportButton";
            this.airportButton.Size = new System.Drawing.Size(333, 60);
            this.airportButton.TabIndex = 0;
            this.airportButton.Text = "Airport Management";
            this.airportButton.UseVisualStyleBackColor = true;
            this.airportButton.Click += new System.EventHandler(this.airportButton_Click);
            // 
            // mainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 662);
            this.Controls.Add(this.airportButton);
            this.Name = "mainGUI";
            this.Text = "Admin Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button airportButton;
    }
}

