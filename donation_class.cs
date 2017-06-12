using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for donation_class
/// </summary>
public class Donations
{
    public string currentDonations;
    public int donationsAmount;
    public string name;
    public int totalDonations;
    public Donations()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string display()
    {
        return "Hello " + name;
    }
    public string viewDonations()
    {
        return currentDonations;
    }
    public int viewDonationAmount()
    {
        return donationsAmount;
    }
    public int getTotal()
    {
        string grantt = "";
        for (int i = 0; i < donationsAmount; i++)
        {
            grantt += "<br>" + donationsAmount;
        }

        return totalDonations;
    }
}