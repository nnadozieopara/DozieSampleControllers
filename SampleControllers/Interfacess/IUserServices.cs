using SampleControllers.Models;

namespace SampleControllers.Interfacess
{
    public interface IUserServices
    {
        List<User> DataBase { get; set; }

        void CreateUser(string userName, string email, string password);
        void DeleteUser(Guid id);
        List<User> GetUsers();
        void UpdateEmail(Guid id, string newEmail);
        void UpdateName(Guid id, string newName);
        User GetUser(Guid id);
    }
}