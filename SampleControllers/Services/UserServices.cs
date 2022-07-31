using SampleControllers.Interfacess;
using SampleControllers.Models;

namespace SampleControllers.Services
{
    public class UserServices : IUserServices
    {
        public List<User> DataBase { get; set; } = new List<User>();

        public void CreateUser(string userName, string email, string password)
        {
            var user = DataBase.FirstOrDefault(x=>x.Email == email && x.Password == password);
            if (user == null)
            {
                DataBase.Add
                (
                        new User()
                        {
                            Email = email,
                            Username = userName,
                            Password = password
                        }
                 );
            }
            
        }

        public void DeleteUser(Guid id)
        {
            var user = DataBase.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                DataBase.Remove(user);
            }
        }

        public List<User> GetUsers()
        {
            return DataBase;
        }

        public void UpdateName(Guid id, string newName)
        {
            var user = DataBase.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                user.Username = newName;
            }
        }

        public void UpdateEmail(Guid id, string newEmail)
        {
            var user = DataBase.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                user.Email = newEmail;
            }
        }

        public User GetUser(Guid id)
        {
            var user = DataBase.FirstOrDefault(x => x.Id == id);
           if(user != null)
            {
                return user;    
            }
            return null;
        }
    }
}
