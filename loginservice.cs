using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoginService" in code, svc and config file together.
public class LoginService : ILoginService
{
    ShowTrackerEntities1 db = new ShowTrackerEntities1();
    public bool RegisterVenue(Venue v, VenueLogin vl)
    {
        bool result = true;
        int pass = db.usp_RegisterVenue(
            v.VenueName,
            v.VenueAddress,
            v.VenueCity,
            v.VenueState,
            v.VenueZipCode,
            v.VenuePhone,
            v.VenueEmail,
            v.VenueWebPage,
            v.VenueAgeRestriction,
            vl.VenueLoginUserName,
            vl.VenueLoginPasswordPlain);
        if (pass == -1)
        {
            result = false;
        }

        return result;


    }

        public int VenueLogin(string username, string password)
        {
        int venueKey = 0;
        int result = db.usp_venueLogin(username, password);
        if (result != -1)
        {
            var key = (from vl in db.VenueLogins
                      where vl.VenueLoginUserName.Equals(username)
                       select new { vl.VenueKey }).FirstOrDefault();


            venueKey = (int)key.VenueKey;
 
        }
        return venueKey;
        }
}




