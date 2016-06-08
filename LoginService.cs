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

    public void AddShow(NewShow s, NewShowDetail sd)
    {
        Show show = new Show();
        ShowDetail showd = new ShowDetail();
        show.ShowName = s.ShowName;
        show.VenueKey = s.VenueKey;
        show.ShowDate = s.ShowDate;
        show.ShowTime = s.ShowTime;
        show.ShowTicketInfo = s.ShowTicketInfo;
        show.ShowDateEntered = DateTime.Now;
        show.ShowKey = sd.ShowKey;
        showd.ArtistKey = sd.ArtistKey;
        showd.ShowDetailArtistStartTime = sd.ShowDetailArtistStartTime;
        showd.ShowDetailAdditional = sd.ShowDetailAdditional;

        db.Shows.Add(show);
        db.SaveChanges();
        db.ShowDetails.Add(showd);
        db.SaveChanges();

    }

    public void AddArtist(NewArtist a)
    {
        Artist art = new Artist();
        art.ArtistName = a.ArtistName;
        art.ArtistEmail = a.ArtistEmail;
        art.ArtistWebPage = a.ArtistWebPage;
        art.ArtistDateEntered = DateTime.Now;

        db.Artists.Add(art);
        db.SaveChanges();
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




