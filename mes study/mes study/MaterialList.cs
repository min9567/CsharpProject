using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mes_study
{
    public class MaterialList
    {
        public int id { get; set; }
        public string uuid { get; set; }
        public string name { get; set; }
        public int qty_in { get; set; }
        public int qty_out { get; set; }
        public int qty_result { get; set; }
        public string registrant { get; set; }
        public string memo { get; set; }
        public DateTime? created_at { get; set; }
    }
}

