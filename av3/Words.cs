using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace av3
{
    class Words
    {
        public string word;
        public string tow;
        public string mean;
        public string date_add;
        public Words()
        {
        
        }
        public Words(string word, string tow, string mean,string the_date_add)
        {
            this.word = word;
            this.tow = tow;
            this.mean = mean;
            date_add = the_date_add;
        }
    }
}
