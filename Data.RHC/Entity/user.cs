using Core.Data.Model.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.RHC.Entity
{
    public class user : IEntity
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool is_active { get; set; }
        public bool is_approve { get; set; }

        public int envorirement_type { get; set; }
        public int user_type { get; set; }
        public DateTime  create_date { get; set; }
    }
}
