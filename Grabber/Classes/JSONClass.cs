using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
        public class JSONResult
        {
            public class ResponseHeader
            {
                public class Params
                {
                    public string q { get; set; }
                    public string qin { get; set; }
                    public string fl { get; set; }
                    public string wt { get; set; }
                    public string rows { get; set; }
                    public int start { get; set; }
                }

                public int status { get; set; }
                public int QTime { get; set; }
                public Params @params { get; set; }
            }

            public class Response
            {
                public class Doc
                {
                    public string btih { get; set; }
                    public List<string> collection { get; set; }
                    public object creator { get; set; }
                    public string date { get; set; }
                    public string description { get; set; }
                    public int downloads { get; set; }
                    //public List<string> format { get; set; }
                    public string identifier { get; set; }
                    public string mediatype { get; set; }
                    public int month { get; set; }
                    public List<string> oai_updatedate { get; set; }
                    public string publicdate { get; set; }
                    public string stripped_tags { get; set; }
                    public object subject { get; set; }
                    public string title { get; set; }
                    public int week { get; set; }
                    public string year { get; set; }
                }


                public int numFound { get; set; }
                public int start { get; set; }
                public List<Doc> docs { get; set; }
            }

            public ResponseHeader responseHeader { get; set; }
            public Response response { get; set; }

           

        }

  
}
