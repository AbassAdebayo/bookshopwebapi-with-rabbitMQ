public interface IUserRepository
{
    Task<User> GetUserById(Guid id);
    Task<User> GetUserByUsername(string username);
    Task<User> CreateUser(User user);
}