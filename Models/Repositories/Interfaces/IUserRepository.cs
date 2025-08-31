

public interface IUserRepository
{
    public void AddUser(User user);
    User GetUser(int Id);
    User GetUserByEmail(string email);
    List<User> GetUsers(); 
}