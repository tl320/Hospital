<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm.aspx.cs" Inherits="WebForm" %>

<!DOCTYPE html>
<link rel="stylesheet" href="StyleSheet.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Patient Schedule Page</title>
</head>

<body>
  <form id="scheduleForm" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
          <h1>
        <!-- header 1 named "Patient Account" --> Patient Account Details
    </h1>

    <div class="Patient Info">
    <h2>
        <!-- header 2 is the patient being able to provide thier full name (first and last)-->
        First and Last Name:
    </h2>
    
        <label>First name: <input type="text" id="fname" name="fname" placeholder="Patient First Name" required = "required" /></label>
        
        <label>Last name: <input type="text" id="lname" name="lname" placeholder="Patient Last Name" required = "required" /></label>
        <label>Email: <input type ="email" id="email" placeholder="patient@example.com" required="required" /></label>
        <br />
    
        <h3>
            <label>Phone Number:<input type="tel" name="Phone Number" title="Phone Number" pattern="[0-9]{10}" placeholder="1234567890" required = "required" /></label>

        </h3>
        </div>
  
     <hr />
   
         <div class="Appointment-Section">
        
            <div class="Appointment Details">
                <h4>
                    Record your Appointment
                </h4>
                 <input type="text" id="event" name="event" placeholder="e.g. Checkup" required ="required" />
                 <input type="date" id="date" name="date" required = "required" />
                 <input type="time" id="time" name="time" required = "required" />

             
                 <button type="submit"> Schedule Appointment</button>

                 <div id="successMessage" style="display: none; color: green; margin-top: 10px;">
                     Appointment scheduled successfully!
                 </div>
            </div>
        </div>
      <script src="JavaScript.js"></script>
    </form>
    

</body>
</html>
