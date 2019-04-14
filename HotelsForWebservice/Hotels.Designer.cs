namespace HotelsForWebservice
{
    partial class Hotels
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
            this.lblAirportCode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bgSearch = new System.Windows.Forms.GroupBox();
            this.lblHotelText = new System.Windows.Forms.Label();
            this.lblAirportCodeText = new System.Windows.Forms.Label();
            this.lblAddressText = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.bgSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAirportCode
            // 
            this.lblAirportCode.AutoSize = true;
            this.lblAirportCode.Location = new System.Drawing.Point(28, 92);
            this.lblAirportCode.Name = "lblAirportCode";
            this.lblAirportCode.Size = new System.Drawing.Size(71, 13);
            this.lblAirportCode.TabIndex = 0;
            this.lblAirportCode.Text = "Airport Code: ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(28, 137);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address :";
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Location = new System.Drawing.Point(31, 51);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(69, 13);
            this.lblHotel.TabIndex = 3;
            this.lblHotel.Text = "Hotel Name: ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(294, 88);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(415, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bgSearch
            // 
            this.bgSearch.Controls.Add(this.lblAddressText);
            this.bgSearch.Controls.Add(this.lblAirportCodeText);
            this.bgSearch.Controls.Add(this.lblHotelText);
            this.bgSearch.Controls.Add(this.lblAirportCode);
            this.bgSearch.Controls.Add(this.lblAddress);
            this.bgSearch.Controls.Add(this.lblHotel);
            this.bgSearch.Location = new System.Drawing.Point(233, 130);
            this.bgSearch.Name = "bgSearch";
            this.bgSearch.Size = new System.Drawing.Size(366, 194);
            this.bgSearch.TabIndex = 6;
            this.bgSearch.TabStop = false;
            this.bgSearch.Text = "SearchResults";
            // 
            // lblHotelText
            // 
            this.lblHotelText.AutoSize = true;
            this.lblHotelText.Location = new System.Drawing.Point(106, 51);
            this.lblHotelText.Name = "lblHotelText";
            this.lblHotelText.Size = new System.Drawing.Size(0, 13);
            this.lblHotelText.TabIndex = 4;
            // 
            // lblAirportCodeText
            // 
            this.lblAirportCodeText.AutoSize = true;
            this.lblAirportCodeText.Location = new System.Drawing.Point(106, 92);
            this.lblAirportCodeText.Name = "lblAirportCodeText";
            this.lblAirportCodeText.Size = new System.Drawing.Size(0, 13);
            this.lblAirportCodeText.TabIndex = 5;
            // 
            // lblAddressText
            // 
            this.lblAddressText.AutoSize = true;
            this.lblAddressText.Location = new System.Drawing.Point(106, 137);
            this.lblAddressText.Name = "lblAddressText";
            this.lblAddressText.Size = new System.Drawing.Size(0, 13);
            this.lblAddressText.TabIndex = 6;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(233, 363);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 7;
            // 
            // Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.bgSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtID);
            this.Name = "Hotels";
            this.Text = "Hotels Web Service";
            this.bgSearch.ResumeLayout(false);
            this.bgSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAirportCode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox bgSearch;
        private System.Windows.Forms.Label lblAddressText;
        private System.Windows.Forms.Label lblAirportCodeText;
        private System.Windows.Forms.Label lblHotelText;
        private System.Windows.Forms.Label lblError;
    }
}

