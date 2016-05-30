using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    SelectServiceReference.ServiceClient swc
        = new SelectServiceReference.ServiceClient { };
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            FillArtistDropDownList();
            FillVenueDropDownList();
            FillShowDropDownList();
    }

    protected void FillArtistDropDownList()
    {
        string[] artists = swc.GetArtists();
         ArtistDropDownList.DataSource = artists;
        ArtistDropDownList.DataBind();
    }

    protected void ShowButton_Click(object sender, EventArgs e)
    {
        string ArtistName = ArtistDropDownList.SelectedItem.Text;
        SelectServiceReference.ShowArtistLite[] show= swc.ShowArtistShows(ArtistName);
        ShowGridView.DataSource = show;
        ShowGridView.DataBind();
    }

    protected void FillVenueDropDownList()
    {
        string[] venues = swc.GetVenues();
        VenueDropDownList.DataSource = venues;
        VenueDropDownList.DataBind();
    }

    protected void VenueButton_Click(object sender, EventArgs e)
    {
        string VenueName = VenueDropDownList.SelectedItem.Text;
        SelectServiceReference.ShowLite[] show = swc.ShowShows(VenueName);
        ShowGridView2.DataSource = show;
        ShowGridView2.DataBind();
    }

    protected void FillShowDropDownList()
    {
        string[] ShowName = swc.GetShows();
        ShowDropDownList.DataSource = ShowName;
        ShowDropDownList.DataBind();
    }

}
