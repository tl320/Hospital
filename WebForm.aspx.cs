using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Net;
using System.Net.Mail;

public partial class WebForm : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod]
    public static string ScheduleAppointment(string eventName, string date, string time, string email)
    {
        // This is where you'd normally save to a database
        if (string.IsNullOrEmpty(eventName) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(time) || string.IsNullOrEmpty(email))
        {
            return "Error: Missing information.";
        }

       string successMessage = string.Format("Appointment scheduled successfully for {0} on {1} at {2}!", eventName, date, time);

        try
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("Stev26276@gmail.com"); //placeholder email for now (using it for testing)
            mail.To.Add(email);
            mail.Subject = "Appointment Confirmation";
            mail.Body = string.Format("Hello, \n\nYour {0} appointment has been set for {1} at {2}", eventName, date, time);
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("Stev26276@gmail.com", "ctea eyil dnaz gofc"); // the second arguement is a security feature, a static password speciically for the website that has 16 characters 
            smtp.Send(mail);                                                             // to put simply im giving the website a special 'key' conencted to my google account that only i know of, the website will immediately know its me instead of an anonymous user 

        }
        catch (Exception ex) {
            return successMessage + "(Confirmation email failed to send." + ex.Message + ")"; //if the password fails, the appointment will still be booked but a warning will be sent as well
        }
        return successMessage;

    }
    
}