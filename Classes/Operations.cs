using Grabber;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    class Operations
    {


    }
    public static class UIOperations
    {
       public static ListBox logger;
        public static void Log( string message)
        {
            logger.Items.Add(String.Format("{0} - {1}",Date.getTime().ToString(), message));
        }
    }

    public static class Network
    {
       public static WebClient wb = new WebClient();

       public static async Task<string> downloadStringUrl(string url)
       {
           string result = null;

           try
           {
               result = await wb.DownloadStringTaskAsync(url);
           }

           catch (Exception ex)
           {
               UIOperations.Log(ex.Message);
           }

           return result;
       }

       public static void DownloadFile(string address, string filename)
       {
           Uri Uri = new Uri(address);

           wb.DownloadFileCompleted += new  AsyncCompletedEventHandler(Completed);
           wb.QueryString.Add("fileName", filename);


         //  client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
           UIOperations.Log(String.Format("Download started: {0}", filename));
           try
           {
              wb.DownloadFileAsync(Uri, System.Environment.CurrentDirectory + "/Data/" + filename);
              while (wb.IsBusy) { Application.DoEvents(); } 
           }

           catch(Exception ex)
           {
               UIOperations.Log(ex.Message);
           }
       }

       private static void Completed(object sender, AsyncCompletedEventArgs e)
       {
           string fileName = ((System.Net.WebClient)(sender)).QueryString["fileName"];
           UIOperations.Log(String.Format("Download completed: {0}", fileName));
       }

       
    }
}
