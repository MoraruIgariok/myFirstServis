using MyFirstShop.Table;

namespace MyFirstShop.Services
{
    public interface IClientService
    {
        public ClientAddResponse AddClient(ClientAddRequest client);
        public ClientEditResponse EditClient(ClientEditRequest client);
        public ClientGetResponse GetClient(ClientGetRequest client);
        public Client GetClientById(ClientGetByIdRequest client);
    }
}
