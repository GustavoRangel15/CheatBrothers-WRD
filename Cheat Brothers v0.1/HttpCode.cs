using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;


namespace APISender
{
    public static class SENDER
    {
        // Token: 0x06000005 RID: 5 RVA: 0x00002B7C File Offset: 0x00000D7C
        public static byte[] Post(string uri, NameValueCollection pairs)
        {
            byte[] result = null;
            using (WebClient webClient = new WebClient())
            {
                result = webClient.UploadValues(uri, pairs);
            }
            return result;
        }
    }
}
