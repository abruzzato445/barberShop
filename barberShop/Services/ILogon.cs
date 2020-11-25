using barberShop.Entities;

namespace barberShop.Services
{
    interface ILogon
    {
        public void CheckUser(string nameUser, long passwordUser);
    }
}
