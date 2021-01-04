using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWPFSample
{
    class Test
    {
        string simpleCookie = "CSCUser1=DonJoe";
        string cookieWithExpiration = "CSCUser2=DonJoe;expires=Mon, 1-Mar-2021 00:00:00 GMT";

        Uri simpleCookieUri = new Uri(@"C:\Junk\SimpleCookie");
        Uri persistenetCookieUri = new Uri(@"C:\Junk\PersistentCookie");

        Application.SetCookie(simpleCookieUri, simpleCookie);
        Application.SetCookie(persistenetCookieUri, cookieWithExpiration);

    }
}
