
public class UserRepository : IUserRepository
{
    public static List<User> UserList = [];
    public void AddUser(User user)
    {
        UserList.Add(user);
    }

    public User GetUser(int Id)
    {
        var user = UserList.Where(x => x.Id == Id).FirstOrDefault();
        return user;
    }

    public User GetUserByEmail(string email)
    {
        var user = UserList.Where(x => x.Email == email).FirstOrDefault();
        return user;
    }

    public List<User> GetUsers()
    {
        var users = UserList.ToList();
        return users;
    }
}