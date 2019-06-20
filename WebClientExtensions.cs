using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace ReeCode
{
    public static class WebClientExtensions
    {
        /// <summary>
        /// Sets the Forwarded header
        /// </summary>
        public static WebClient SetForwarded(this WebClient theWebClient, string via)
        {
            WebClient wc = theWebClient;
            theWebClient.Headers["Forwarded"] = via;
            return wc;
        }

        /// <summary>
        /// Sets the Via header
        /// </summary>
        public static WebClient SetVia(this WebClient theWebClient, string via)
        {
            WebClient wc = theWebClient;
            theWebClient.Headers["Via"] = via;
            return wc;
        }

        /// <summary>
        /// Sets the Cookie
        /// </summary>
        public static WebClient SetCookie(this WebClient theWebClient, string cookie)
        {
            WebClient wc = theWebClient;
            theWebClient.Headers["Cookie"] = cookie;
            return wc;
        }

        /// <summary>
        /// Sets the Content Type
        /// </summary>
        public static WebClient SetContentType(this WebClient theWebClient, string contentType)
        {
            WebClient wc = theWebClient;
            theWebClient.Headers["Content-Type"] = contentType;
            return wc;
        }

        /// <summary>
        /// Makes a WebClient POST request, and returns the result as a string
        /// </summary>
        public static string Post(this WebClient theWebClient, string URL, List<string> postValues)
        {
            NameValueCollection postCollection = new NameValueCollection();

            if (postValues != null)
            {
                foreach (string item in postValues)
                {
                    string key = item.Split('=')[0];
                    string value = item.Remove(0, key.Length + 1);
                    postCollection.Add(key, value);
                }
            }
            byte[] responseBytes = theWebClient.UploadString((URL, "POST", postCollection);
            string responseString = Encoding.UTF8.GetString(responseBytes);
            return responseString;
        }
    }
}