namespace FlightReservationSystem.Excp
{
    partial class ExceptionGUI
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
            this.excpLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // excpLbl
            // 
            this.excpLbl.AutoSize = true;
            this.excpLbl.Location = new System.Drawing.Point(99, 90);
            this.excpLbl.Name = "excpLbl";
            this.excpLbl.Size = new System.Drawing.Size(51, 20);
            this.excpLbl.TabIndex = 0;
            this.excpLbl.Text = "label1";
            // 
            // ExceptionGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 218);
            this.Controls.Add(this.excpLbl);
            this.Name = "ExceptionGUI";
            this.Text = "ExceptionGUI";
            this.Load += new System.EventHandler(this.ExceptionGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label excpLbl;
    }
}