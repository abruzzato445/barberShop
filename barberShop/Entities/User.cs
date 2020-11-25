using barberShop.Services;

namespace barberShop.Entities
{
    class User
    {
        public string nameUser { get; private set; }
        public long passwordUser { get; private set; }

        public User(string name, long password, ILogon logon)
        {
            nameUser = name;
            passwordUser = password;
            logon.CheckUser(nameUser, passwordUser);
        }

    }
}
