using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class UserRepositoryInMemory : IUserRepository
    {
        private static List<User> users = new List<User>()
        {
            new User("Алина", "Бзыкова", "bzykovaaa@gmail.com"),
            new User("Настя", "Иванова", "ivanova@gmail.com"),
            new User("Мария", "Петрова", "petrova@gmail.com")
        };

        public List<User> GetAll()
        {
            return users;
        }

        public User? TryGetById(Guid id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }
    }
}