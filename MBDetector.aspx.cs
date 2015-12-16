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

        }

        protected void rdbQRCoder_Changed(object sender, EventArgs e)
        {
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
            var message = twilio.SendSmsMessage("+1 228-207-5756", "+919819718463", UniqueID + "One time Password. Please do not share with anyone. Please notify if not done by you.");
            //Console.WriteLine(message.Sid);
            //Console.WriteLine(message.Status.ToString());

            //if (message == null)
            //{
            //    NotificationServiceFactory.NotificationService.NotifyTechSupport("Error sending SMS to 919819718463", "twilio.SendSmsMessage returned null.\n\n" + message);
            //    return CreateCustomerResultCode.SmsCommunicationError;
            //}

            if (message.RestException != null)
            {
                var error = message.RestException.Message;
                // handle the error ...
                Console.WriteLine("Message :" + error);
            }
        }       
    }
}