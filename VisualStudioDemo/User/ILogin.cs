namespace VisualStudioDemo
{
    public interface ILogin
    {
        User RegisterUser(User user);
        bool LoginUser(string username, string password);
    }
}
