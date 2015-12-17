<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MBDetector.aspx.cs" Inherits="GISTEAMA1.MBDetector" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
 <style type="text/css">
     .auto_Header_text {
         font-family : Verdana;
         font-size : x-small;
         font-weight : bold;
         color:white;
     }
      .auto_label {
         font-family : Verdana;
         font-size : x-small;
         font-weight : normal;
         color:white;
     }
       .auto_textbox {
         font-family : Verdana;
         font-size :xx-small;
         font-weight : normal;
         color:white;
     }
        .auto_footer {
         font-family : Verdana;
         font-size :xx-small;
         font-weight : normal;
         color:white;
     }
 </style>
</head>
<body>  
    <form id="form1" runat="server">
    <div id="container">
     <div id="dvGenerate" class="signin">
       <table border="1" width="70%" align="center">
           <tr class="auto_Header_text">
               <td colspan="2">Billdesk</td>
           </tr>
            <tr class="auto_Header_text">
               <td>Merchant</td>
                <td>Bill Amount</td>
           </tr>
              <tr class="auto_label">
               <td>
                   <asp:Label ID="lblMerchant" runat="server" Text=""></asp:Label></td>
                <td>
                    <asp:Label ID="lblAmount" runat="server" Text=""></asp:Label></td>
           </tr>
           <tr>
               <td colspan="2"><br /></td>
           </tr>
           <tr class="auto_Header_text">
               <td colspan="2">
                   <asp:RadioButton ID="rdbQRCoder" runat="server" AutoPostBack="true" OnCheckedChanged="rdbQRCoder_Changed" 
                       Text="I want to choose the Quick Response Code for my online payment" /></td>             
           </tr>
            <tr>
               <td colspan="2"><br /></td>
           </tr>
           <tr  class="auto_label">
               <td><asp:Label ID="lblCardHolderName" runat="server" Text="Card Holder Name"></asp:Label></td>
               <td><asp:Label ID="lblExpiryDate" runat="server" Text="Card Expiry Date"></asp:Label></td>
           </tr>
           <tr class="auto_textbox">
               <td><asp:TextBox ID="txtName" runat="server" Width="150px"></asp:TextBox></td>
               <td><asp:TextBox ID="txtExpDate" runat="server" Width="100px"></asp:TextBox></td>
           </tr>
           <tr  class="auto_label">
               <td><asp:Label ID="lblAccount" runat="server" Text="Account No"></asp:Label></td>
               <td><asp:Label ID="lblCVV" runat="server" Text="CVV No"></asp:Label></td>
           </tr>
             <tr class="auto_textbox">
               <td><asp:TextBox ID="txtAccount" runat="server" Width="150px"></asp:TextBox></td>
               <td><asp:TextBox ID="txtCVV" runat="server" Width="50px"></asp:TextBox></td>
           </tr>
            <tr>
               <td colspan="2"><br /></td>
           </tr>
           <tr>
               <td colspan="2"><br /></td>
           </tr>
             <tr class="auto_Header_text">
               <td colspan="2">
                   <asp:RadioButton ID="rdbOTP" runat="server" AutoPostBack="true"
                       Text="I want to generate One Time Password for my online payment" /></td>             
           </tr>
            <tr>
               <td align="center" class="auto_Header_text"><asp:Button ID="btnGenerate" runat="server" Text="Generate OTP" OnClick="btnGenerate_Click" Width="179px" /></td>
               <td align="center" class="auto_textbox"><asp:TextBox ID="txtOTP" runat="server" Width="100px"></asp:TextBox></td>
           </tr>
           <tr>
               <td colspan="2"> <hr /></td>
           </tr>
            <tr>
               <td colspan="2"><br /></td>
           </tr>
          <tr class="auto_Header_text">
               <td colspan="2">
                   <asp:RadioButton ID="rdbFaceDetector" runat="server" AutoPostBack="true"
                       Text="I want to use my camera for Face Detection for my online payment" /></td>             
           </tr>
             <tr>
               <td colspan="2"><br /></td>
           </tr>
             <tr>
               <td colspan="2" class="auto_label">
                   <asp:PlaceHolder ID="plhFaceDetector" runat="server"></asp:PlaceHolder>
               </td>
           </tr>
             <tr>
               <td colspan="2"><br /></td>
           </tr>

             <tr>
               <td colspan="2" align="center" class="auto_Header_text"><asp:Button ID="btnMakePayment" runat="server" Text="Proceed for Payment" Width="296px" /></td>
            </tr>
            <tr>
                <td colspan="2"><hr /></td>
            </tr>
            <tr>
                <td colspan="2" class="auto_footer">
                    Your Transaction is processed through a secure https internet connection based on secure socket layer technology. For Security purpose
                    your IP address xxx.xxx.xxx.xx and access Date and Time <%=DateTime.Now.ToString() %>> has been logged.
                </td>
            </tr>
            <tr>
                <td colspan="2"><hr /></td>
            </tr>   
           <tr>
                <td colspan="2" class="auto_footer"><p>Copyright &copy; TCS-GIS TEAM-A1</p></td>
            </tr>        
       </table>
       </div>       
    </div>
   
    </form>
</body>
</html>
