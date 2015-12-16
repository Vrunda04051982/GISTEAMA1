using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QRCoder;
using System.IO;
using System.Drawing;

namespace GISTEAMA1
{
    public partial class GenerateScan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
            System.Web.UI.WebControls.Image imgBarCode = new System.Web.UI.WebControls.Image();
            imgBarCode.Height = 150;
            imgBarCode.Width = 150;
            using (Bitmap bitMap = qrCode.GetGraphic(20))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] byteImage = ms.ToArray();
                    imgBarCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);

                    string filepath = Server.MapPath("~/Scandetails/details1.png");
                    FileStream file = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                    ms.WriteTo(file);
                    file.Close();
                    ms.Close();
                }
                plBarCode.Controls.Add(imgBarCode);
            }
        }
    }
}