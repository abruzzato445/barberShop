using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using barberShop.Entities;

namespace barberShop.Services
{
    class SecurityDefault : ILogon
    {
        private string connect;
        List<User> users = new List<User>();

        public void CheckUser(string nameUser, long passwordUser)
        {
            string[] user = new string[2];
            user[0] = nameUser;
            user[1] = passwordUser.ToString();
            try
            {
                //connection
                connect = "Port=5433;Host=localhost;Database=main_db;Username=postgres;Persist Security Info=True;Password=***********";
                using (NpgsqlConnection connection = new NpgsqlConnection(connect))
                {
                    connection.Open();
                    
                }
            }
            catch ()
            {

            }
        }
    }
}
