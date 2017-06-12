using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Login_class
/// </summary>
public class Grants
{
    public string grantName;
    public int grantNumber;
    public string name;
    public Grants()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string display()
    {
        return "Hello " + name;
    }
    public string viewGrants()
    {
        return grantName + grantNumber;
    }
    
  }
