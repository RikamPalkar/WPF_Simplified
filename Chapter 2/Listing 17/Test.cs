using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWPFSample
{
    public class SaveCookie
    {
        const string simpleCookie = "CSCUser1=DonJoe";
        const string cookieWithExpiration = "CSCUser2=DonJoe;expires=Mon, 1-Mar-2021 00:00:00 GMT";

        var simpleCookieUri = new Uri(@"C:\Junk\SimpleCookie");
        var persistentCookieUri = new Uri(@"C:\Junk\PersistentCookie");

        Application.SetCookie(simpleCookieUri, simpleCookie);
        Application.SetCookie(persistentCookieUri, cookieWithExpiration);

    }
}
