using barberShop.Services;

namespace barberShop.Entities
{
    class User
    {
        public string nameUser { get; }
        public long passwordUser { get; }

        public User(string name, long password, ILogon logon)
        {
            nameUser = name;
            passwordUser = password;
            logon.CheckUser(nameUser, passwordUser);
        }

    }
}
