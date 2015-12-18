# GISTEAMA1
New Hackathon Web Application
Document Name:	Solution Design Document
Project Name:	Payments using Visual Recognition and Quick Response code.

Group Name:	GIS TEAM A1  


Document Version:	1.0

Document Revised:	

Template Version:	 1.0
Template Release Date	11/03/15
PROCESS ASSETS LIBRARY LINKS
Project Repository:	GITHub

POINT OF CONTACT
For issues or questions related to document content, document control, location or access, please notify the contact(s) below: 
Name	Org/Group	Role	Phone
Vrunda Vanjare	TCS	Developer	
Sreejith Gopinath	TCS	Developer	
Rinu Abraham	TCS	Developer	
Vishwakarma Ashwani	TCS	Developer 	
Ravi Kumar	TCS	Developer 	
Ashish Dubey	TCS	Developer 	
Chennoju Shantikumar	TCS	Developer 	

REVISION HISTORY
Rev. #	Date	Sect./Page #	Revision Summary	Author
v01.00	MM/DD/YY			
				
				
				
				


Click Here To Go To Definitions List
 

TABLE OF CONTENTS
1.0	PROJECT BACKGROUND	3
1.1.	Project Charter	3
1.1.1.	Project Objective	3
1.1.2.	Scope	3
1.1.3.	Assumptions, Dependencies, and Constraints	4
2.0	FLOW AND CLASS DIAGRAM	5
2.1.	Flow Diagram	5
2.2.	Class Diagram	6
3.0	ENGINEERING REQUIREMENTS	7
3.1.	Current Technology Environment	7
3.2.	Target Technology Environment	7
3.3.	Services to be utilized from IBM Bluemix	7
3.4.	Functional Requirements	8
3.5.	Information of the Environment	9
4.0	APPENDIX	11
4.1.	Related Documents	11
4.2.	Definitions	11

 
1.0 	Project Background
1.1.	Project Charter
1.1.1.	Project Objective
A new payment mode to ensure more reliable, easier and secure way of online shopping. This payment reduces the difficulties which customer might face during the payment ,like insecure feeling as there card details are store on other online e-commerce website or remembering the passwords or entering the  card details and the CVV number. So the new payment method can be replaced with the existing systems to meet the following.

1.1.1.1 To make the online payments more secure and reliable.
1.1.1.2 To make the online payments more efficient in terms of remembering the passwords.
1.1.1.3 To prevent the payment details being leaked out.


1.1.2.	Scope 

Over the years, credit cards have become one of the most common forms of payment for e-commerce transactions. Increased security measures include use of the card verification number (CVV) which detects fraud by comparing the verification number printed on the signature strip on the back of the card with the information on file with the cardholder's issuing bank. The security issues are the main scope which we cover here. This avoids the payment details being leaked out as well.

A credit card transaction requires a minimum of four parties -the purchaser, the seller, the issuing bank, and the acquiring bank. The scope we have here is to make the transactions more reliable, easier to the parties involved in the transactions.

The key to the above  is the scope and is as below.

1.1.2.1 Generating QR “Quick Response” Code
1.1.2.2 Scan QR code and it will be transferred to the bank website for Verification.
1.1.2.3 Authentication using Face Detector as primary option and OTP as secondary option.

 
Project Impact Summary


1.1.3.	Assumptions, Dependencies, and Constraints 

#	Assumptions, Dependencies, & Constraints	Raised by (optional)	Confirmed By	Date
	Assumptions			
1.		Debit Card will have the facility of QR Code Printed at the back instead of Account no and CVV no.	Vrunda/Ashish		11/03/2015
	Dependencies			
1.		Camera Mobiles with Internet Facility	Vrunda/Ashish		11/03/2015
	Constraints			
    1.	QR code and Face detector will be available from the web page only if camera is available.
	Ashwani		11/03/2015
2.0 	Flow and Class Diagram

2.1.	Flow Diagram


 



2.2.	Class Diagram

 
 
3.0 	Engineering Requirements 
3.1.	Current Technology Environment

1.	IBM Bluemix Technology

3.2.	Target Technology Environment

1.	Visual studio 2013
2.	Eclipse 4.0
3.	Android 5.0
4.	Windows OS
5.	Android OS

3.3.	Services to be utilized from IBM Bluemix
1.	 Alchemy API Service – PHP for Face Detection
2.	 Visual Recognition IBM Beta Service – Webapps for Face Detection
3.	 Charts.google.apis Service – For QR Coder Generation
4.	 QR and Bar code scanner service - For Mobile and web for Reading the QR Code
5.	 Tivoli Service – One Time Password Generation Technique using IBM ISAM for mobile.

 
3.4.	Functional Requirements

Traces to 
	Functional Req #
	Category 

(optional)	Traces to Process Step(s)

(Optional) 	Requirement Short name

(Optional)	Priority

1-Essential
2-Critical
3 –Nice to Have	Functional  Requirement Statement

(System Shall (function to be provided) so that (Any Criteria used to Determine Success)
or
(System Shall enable (User) to (function to be provided) so that (Any Criteria used to Determine Success)





	

1	QR code on ATM or Debit card
				2	Generate online QR code/provide the new card with QR code
Scan QR code using camera and it will be transferred to the bank Database for Verification.

2	Authentication
				2	Face Detection using camera mobile and it will be verified with bank database / OTP will be verified using sms facility on mobile with bank generated OTP in database.

1.	QR code on ATM or Debit card
1.	Generate online QR code/provide the new card with QR code .
2.	Scan QR code and it will be transferred to the bank website for Verification.


2.	Authentication
1.	  Primary Option: Face Detector
a.	Take selfie and identify the Face using Biometrics.
b.	Compare captured Image with DB.
2.	  Secondary option:  OTP
a.	User gets “ONE TIME PASSWORD” to complete transaction.




 
3.5.	Information of the Environment  

1.	Face Detection using AlchemyAPI Service
                 The face detection function of the AlchemyAPI service on IBM Bluemix™. The face detection feature can:
•	Study images and determine whether there are faces.
•	Determine the gender and estimated age of the face.
•	Attempt to identify the face, pulling from a corpus of over 60,000 well-known people.

2.	Using the new Bluemix Visual Recognition service
         The Visual Recognition Service classifies the images you upload against the label groups and labels. For each image, the response includes a score for a label if the score meets the minimum threshold of 0.5. If no score meets the threshold for an image, no labels are returned.
The operation consumes both parameters as multipart/form-data This section is based on Data Management policies and standards, providing guidelines for effective data and information management.It establishes a framework for how data is managed across critical information systems. 
3.	 Create a Quick Response Code (QR Code) image using Google Chart

         QR Coder is similar to the familiar barcode that has been in use for years to track and price products.  The key difference between the two dimensional QR code and the single dimensional barcode is the amount of data they contain. Quick Response codes are also known as hardlinks or physical world hyperlinks. QR Codes store up to 4,296 alphanumeric characters of arbitrary text. This text can be anything, for example, a URL, contact information, a telephone number, even a blog post!  QR codes can be read by an optical device with the appropriate software. Such devices range from dedicated QR code readers to mobile phones.
 
By scanning a QR code with your iPhone or other camera enabled smart device, you activate any number of phone functions, including linking your phones web browser to a web page destination.


4.	ZXing libraries in Android app for reading the Scan QR Code or Bar Code
     ZXing ("zebra crossing") is an open-source, multi-format 1D/2D barcode image processing library implemented in Java. It is capable of porting to many other programming languages as well. One can download the complete library and add it to project and called an Intent with URI:"com.google.zxing.client.android.SCAN". Just like any other activity in android, capture activity also need to be defined in the project manifest. You have to give the project permission to use the camera. Then after running the scanner and capture the QR code,  the results will be retrieved from the scan in onActivityResult() Method.

Alternative to ZXing Library is ZBAR. Much more simpler and easy to implement. One can download the complete library and add it to project and called an Intent with URI:"com.dm.zbar.android.scanner.ZBarScannerActivity". Once the resultset is returned IBM Push Notification services will push the data to the Application.  


5.	IBM Tivoli Identity Manager

             IBM Security Access Manager for Mobile (ISAM for Mobile) allows a security architect to perform context-based authorization (CBA) decisions. Users provide a onetime-use password that is generated for an authentication event and is typically communicated between the client and the server through a secure channel. The OTP mechanism groups all the supported one-time passwords methods in a single flow and allows to select which one-time password method. The supported one-time password authentication methods are: 
•	HOTP
•	TOTP
•	RSA OTP
•	MAC OTP with SMS delivery
•	MAC OTP with email delivery









4.0 	Appendix
4.1.	Related Documents
Document Name	Version #	Link
		
		
		



4.2.	Definitions

Term	Description






QR Code	Quick Response Code
OTP	One Time Password

