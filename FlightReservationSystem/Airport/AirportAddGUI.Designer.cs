namespace FlightReservationSystem.Airport
{
    partial class AirportAddGUI
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.airportIdLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.countryLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.airportIdTxt = new System.Windows.Forms.TextBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.countryTxt = new System.Windows.Forms.TextBox();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.airportAddSaveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(28, 50);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(51, 20);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "label1";
            // 
            // airportIdLbl
            // 
            this.airportIdLbl.AutoSize = true;
            this.airportIdLbl.Location = new System.Drawing.Point(28, 111);
            this.airportIdLbl.Name = "airportIdLbl";
            this.airportIdLbl.Size = new System.Drawing.Size(51, 20);
            this.airportIdLbl.TabIndex = 1;
            this.airportIdLbl.Text = "label1";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(28, 171);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(51, 20);
            this.cityLbl.TabIndex = 2;
            this.cityLbl.Text = "label1";
            // 
            // countryLbl
            // 
            this.countryLbl.AutoSize = true;
            this.countryLbl.Location = new System.Drawing.Point(28, 231);
            this.countryLbl.Name = "countryLbl";
            this.countryLbl.Size = new System.Drawing.Size(51, 20);
            this.countryLbl.TabIndex = 3;
            this.countryLbl.Text = "label1";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(28, 288);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(51, 20);
            this.statusLbl.TabIndex = 4;
            this.statusLbl.Text = "label1";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(200, 44);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(321, 26);
            this.nameTxt.TabIndex = 5;
            // 
            // airportIdTxt
            // 
            this.airportIdTxt.Location = new System.Drawing.Point(200, 105);
            this.airportIdTxt.Name = "airportIdTxt";
            this.airportIdTxt.Size = new System.Drawing.Size(321, 26);
            this.airportIdTxt.TabIndex = 6;
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(200, 165);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(321, 26);
            this.cityTxt.TabIndex = 7;
            // 
            // countryTxt
            // 
            this.countryTxt.Location = new System.Drawing.Point(200, 225);
            this.countryTxt.Name = "countryTxt";
            this.countryTxt.Size = new System.Drawing.Size(321, 26);
            this.countryTxt.TabIndex = 8;
            // 
            // statusTxt
            // 
            this.statusTxt.Location = new System.Drawing.Point(200, 282);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(321, 26);
            this.statusTxt.TabIndex = 9;
            // 
            // airportAddSaveButton
            // 
            this.airportAddSaveButton.Location = new System.Drawing.Point(342, 380);
            this.airportAddSaveButton.Name = "airportAddSaveButton";
            this.airportAddSaveButton.Size = new System.Drawing.Size(179, 49);
            this.airportAddSaveButton.TabIndex = 10;
            this.airportAddSaveButton.Text = "button1";
            this.airportAddSaveButton.UseVisualStyleBackColor = true;
            this.airportAddSaveButton.Click += new System.EventHandler(this.airportAddSaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(32, 380);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(188, 49);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "button1";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AirportAddGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 464);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.airportAddSaveButton);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.countryTxt);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.airportIdTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.countryLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.airportIdLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "AirportAddGUI";
            this.Text = "New Airport";
            this.Load += new System.EventHandler(this.AirportAddGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label airportIdLbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label countryLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox airportIdTxt;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.TextBox countryTxt;
        private System.Windows.Forms.TextBox statusTxt;
        private System.Windows.Forms.Button airportAddSaveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}