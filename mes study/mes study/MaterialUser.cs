using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mes_study
{
    internal class MaterialUser
    {
        public int id { get; set; }
        public string user_id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string birth { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string memo { get; set; }
        public DateTime? created_at { get; set; }

    }
}
