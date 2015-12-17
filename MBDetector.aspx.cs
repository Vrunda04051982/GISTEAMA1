using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Twilio;
using OnBarcode.Barcode.BarcodeScanner;
using System.IO;
using System.Net;


namespace GISTEAMA1
{
    public partial class MBDetector : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMerchant.Text = "Vodafone";
            lblAmount.Text = "250";
            lblCardDetails1.Visible = false;
            lblCardDetails2.Visible = false;
            lblCardDetails3.Visible = false;
            lblCardDetails4.Visible = false;
        }

        protected void rdbQRCoder_Changed(object sender, EventArgs e)
        {
            lblCardDetails1.Visible = true;
            lblCardDetails2.Visible = true;
            lblCardDetails3.Visible = true;
            lblCardDetails4.Visible = true;

            string filepath = Server.MapPath("~/Scandetails/details1.png");
            string[] strQRDecode = BarcodeScanner.Scan(filepath, BarcodeType.QRCode);
            string[] data= null;

            foreach(var substring in strQRDecode)
            {
                data = substring.Split('|');
            }

            if (data != null)
            {
                txtName.Text = data[0];
                txtExpDate.Text = data[1];
                txtAccount.Text = data[2];
                txtCVV.Text = data[3];
            }
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            lblCardDetails1.Visible = true;
            lblCardDetails2.Visible = true;
            lblCardDetails3.Visible = true;
            lblCardDetails4.Visible = true;

            int UniqueID;
            Random rand = new Random();
            UniqueID = rand.Next(100000, 999999);

            string AccountID = "ACd850fc7c178f3bdc5d30771be0b9de40";
            string Token = "745bf7e7c4171a2613627018ec7df5dc";

            //ACd850fc7c178f3bdc5d30771be0b9de40 -- Live
            //745bf7e7c4171a2613627018ec7df5dc

            //string AccountID = "ACc387f71c272af489547f880e570d862c";    -TEST
            //string Token = "6f5348ac6fdf594401ba7ed122db305f";

            var twilio = new TwilioRestClient(AccountID, Token);
            var message = twilio.SendMessage("+1 228-207-5756", "+919819718463", " One time Password is " + UniqueID  + ". Please do not share with anyone. Please notify if not done by you.");
            Console.WriteLine(message.Sid);
            Console.WriteLine(message.Status.ToString());         

            if (message.RestException != null)
            {
                var error = message.RestException.Message;              
                Console.WriteLine("Message :" + error);
            }
        }

        protected void rdbFaceDetector_CheckedChanged(object sender, EventArgs e)
        {
            lblCardDetails1.Visible = false;
            lblCardDetails2.Visible = false;
            lblCardDetails3.Visible = false;
            lblCardDetails4.Visible = false;
        }

        protected void btnMakePayment_Click(object sender, EventArgs e)
        {
            if(UniqueID == txtOTP.Text)
            {
                ClientScript.RegisterClientScriptBlock(typeof(Page), "myscript", "alert('Payment Successful')", true);
            }
        }       
    }
}