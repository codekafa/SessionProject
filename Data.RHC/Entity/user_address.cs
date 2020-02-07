using Core.Data.Model.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.RHC.Entity
{
    public class user_address : IEntity
    {

        public int id { get; set; }

        public int user_id { get; set; }

        public string address { get; set; }

        public string phone { get; set; }

        public int city_id { get; set; }

        public int district_id { get; set; }

        public string zip_code { get; set; }

    }
}
