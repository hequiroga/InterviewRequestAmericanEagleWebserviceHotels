using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelsForWebservice
{
    public partial class Hotels : Form
    {
        public Hotels()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Search event for Hotel webservice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            clearData();

            HotelsForWebservice.HotelsService.HotelCredentials soap = new HotelsService.HotelCredentials();
            soap.username = "aeTraining";
            soap.password = "ZZZ";

            try
            {

                HotelsService.HotelsSoapClient client = new HotelsService.HotelsSoapClient();

                lblHotelText.Text = client.GetHotel(soap, null, Convert.ToInt32(txtID.Text)).Name.ToString();
                lblAirportCodeText.Text = client.GetHotel(soap, null, Convert.ToInt32(txtID.Text)).AirportCode.ToString();
                lblAddressText.Text = client.GetHotel(soap, null, Convert.ToInt32(txtID.Text)).Address1.ToString();
            }
            catch (Exception ex)
            {
                lblError.Text = "The following error occured please validate your inputs.\n" + ex.Message; 
            }
            
        }

        /// <summary>
        /// Clear data from form.
        /// </summary>
        private void clearData()
        {
            lblError.Text = "";
            lblHotelText.Text = "";
            lblAirportCodeText.Text = "";
            lblAddressText.Text = "";
        }
    }
}
