using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIT313Assignment2.Models
{
    public class Token
    {
        [PrimaryKey]
        public int Id { get; set; } // for the database
        public string access_token { get; set; } // holds the token string we get from this server
        public string error_description { get; set; } // show error if something goes wrong
        public DateTime expiry_date { get; set; } // gives the date when the token is no longer valid
        public int expires_in { get; set; }

        public Token() { }
    }
}
