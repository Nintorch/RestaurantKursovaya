using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class IdToTextMap
    {
        public int ID { get; set; }
        public string Text { get; set; }

        public IdToTextMap(int id, string text)
        {
            ID = id;
            Text = text;
        }
    }
}
