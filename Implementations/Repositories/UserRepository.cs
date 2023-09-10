
public class UserRepository : IUserRepository
{
    public Task<User> CreateUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserByUsername(string username)
    {
        throw new NotImplementedException();
    }
}