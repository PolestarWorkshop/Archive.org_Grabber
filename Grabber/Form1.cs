using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using System.Configuration;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Grabber
{
    public partial class Form1 : Form
    {

        JSONResult _JSONResult;

        public static class Query
        {
            public static int totalFiles;
            public static int currentFile;

            public static string[] fields = new string[] {


            };
            public static TextBox queryBox;

            public class Parameter
            {
                public string key;
                public string value;
                public string logic;
            }

            public static List<Parameter> paramsList = new List<Parameter>();

            public static void addParam (string _key, string _value, string _logic) {

                Parameter param = new Parameter()
                {
                    key = _key,
                    value = _value,
                    logic = _logic
                };

                paramsList.Add(param);
            }

            public static void prepareQuery(string numOfRows, string searchQuery)
            {
                queryBox.Text = Grabber.Default.queryURL;

                queryBox.Text += searchQuery + " "; 

                int i = 0;
                foreach (Parameter param in paramsList)
                {
                    string _param = (i == 0) ? String.Format("{0}:({1})", param.key, param.value) : String.Format(" {0} {1}:({2})", param.logic, param.key, param.value);
                    queryBox.Text += _param;

                    i++;
                }

                
                queryBox.Text += String.Format("&output={0}&rows={1}", Grabber.Default.output, numOfRows);
            }

        }

        private string _query;
        public string apiQuery
        {
            get
            {
                return _query;
            }

            set
            {
               _query = value;
               query.Text = _query;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UIOperations.logger = this.logs;
            Query.queryBox = this.query;
            UIOperations.Log(this.Text + " Started");

            foreach (string line in File.ReadAllLines("Data/collections.txt"))
            {
                collections.Items.Add(line);
            }

            mediaType.SelectedIndex = 0;

        }

        private void getCollection_Click(object sender, EventArgs e)
        {
            startProcesss.Enabled = true;

            if (collections.SelectedItem == null) { return; }
            Query.paramsList.Clear();
            Query.queryBox.Text = String.Empty;

            Query.addParam("collection", collections.SelectedItem.ToString(), "AND");

            if (mediaType.SelectedIndex != 0)
            {
                Query.addParam("mediatype", mediaType.SelectedItem.ToString(), "AND");
            }
            Query.prepareQuery(rows.Text, searchQuery.Text);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            int index = collections.FindString(searchBox.Text);

            if (index != -1)
            {
                collections.SetSelected(index, true);
            }
                
        }

        private void startProcesss_Click(object sender, EventArgs e)
        {
            getResult();
        }

        private async void getResult()
        {
            startProcesss.Enabled = false;
            resultBox.Items.Clear();
            string result = await Network.downloadStringUrl(Query.queryBox.Text);

            try
            {
                _JSONResult = JsonConvert.DeserializeObject<JSONResult>(result);
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UIOperations.Log(ex.Message);
                return;
            }

            foreach (var item in _JSONResult.response.docs)
            {
                resultBox.Items.Add(item.title);
            }
            startProcesss.Enabled = true;
        }

        private void resultBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = resultBox.SelectedIndex;

            infoBox.Rtf = @"{\rtf1\" +
@" \b Title: \b0 " + _JSONResult.response.docs[index].title + System.Environment.NewLine + 
@"\b Date: \b0 " + _JSONResult.response.docs[index].date + System.Environment.NewLine +
@" \b Description: \b0 " + _JSONResult.response.docs[index].description + System.Environment.NewLine +
@" \b Identifier: \b0 " + _JSONResult.response.docs[index].identifier + System.Environment.NewLine +
@" \b Media Type: \b0 " + _JSONResult.response.docs[index].mediatype + System.Environment.NewLine +
@" \b Year: \b0 " + _JSONResult.response.docs[index].year + System.Environment.NewLine +
@"}";

        }

    private void DownloadFile(string url, string filename)
{
    Network.DownloadFile(url, filename);
}

    private void startDownload_Click(object sender, EventArgs e)
    {
        startDownload.Enabled = false;
        stopDownload.Enabled = true;

        Query.currentFile = 0;

        List<int> IdstoDownload = new List<int>();

        int totalFiles = 0;

        for (int i = 0; i < resultBox.Items.Count; i++)
        {
            if (resultBox.GetItemChecked(i))
            {
                IdstoDownload.Add(i);
                totalFiles++;
            }
        }

        Query.totalFiles = totalFiles;

     
        foreach (int id in IdstoDownload)
        {
            DownloadFile("https://archive.org/compress/" + _JSONResult.response.docs[id].identifier, _JSONResult.response.docs[id].identifier + ".zip");
            Query.currentFile++;
            currentPosition.Text = Query.currentFile + " / " + Query.totalFiles;
        }


        
    }

    private void resultBox_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        int index = resultBox.SelectedIndex;

        Process.Start("https://archive.org/details/" + _JSONResult.response.docs[index].identifier);
    }

    }
}
