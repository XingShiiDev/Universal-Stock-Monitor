using Leaf.xNet;
using System;
using System.Diagnostics;
using System.Media;
using System.Threading;

namespace Universal_Monitor
{
    class monitor
    {
        public static void monitorSites(string url, string key, string keystate, int refreshRate, string cookies)
        {
            string sitePrefix = "";
            try {  sitePrefix = url.SubstringEx("www.", ".com").ToUpper(); }
            catch { sitePrefix = url.ToUpper(); }
            HttpRequest req = new HttpRequest();
            while (true)
            {
                Form1 log = new Form1();

                Thread.Sleep(refreshRate);
                try
                {
                    req.AllowAutoRedirect = false;

                    if (cookies != "")
                        req.AddHeader("cookie", cookies);

                    req.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9")
                        .AddHeader("Accept-Encoding", "gzip, deflate, br")
                        .AddHeader("Accept-Language", "en-US,en;q=0.9")
                        .AddHeader("Connection", "keep-alive")
                        .AddHeader("Sec-Fetch-Dest", "document")
                        .AddHeader("Sec-Fetch-Mode", "navigate")
                        .AddHeader("Sec-Fetch-Site", "same-origin")
                        .AddHeader("Upgrade-Insecure-Requests", "1");
                    var readSource = req.Get(url);

                    if (keystate == "Out Of Stock")
                    {
                        if (readSource.ToString().Contains(key))
                            Console.WriteLine($"[{readSource.StatusCode}][{sitePrefix}] Out of Stock");
                        else if (!readSource.ToString().Contains(key) && !readSource.ToString().Contains("302 Found"))
                        {
                            Console.WriteLine($"[{readSource.StatusCode}][{sitePrefix}] In Stock");
                            SystemSounds.Beep.Play();
                            Process.Start(url);
                            break;
                        }
                    }
                    else if (keystate == "In Stock")
                    {
                        if (readSource.ToString().Contains(key) && !readSource.ToString().Contains("302 Found"))
                        {
                            Console.WriteLine($"[{readSource.StatusCode}][{sitePrefix}] In Stock");
                            SystemSounds.Beep.Play();
                            Process.Start(url);
                            break;
                        }
                        else if (!readSource.ToString().Contains(key))
                            Console.WriteLine($"[{readSource.StatusCode}][{sitePrefix}] Out of Stock");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
