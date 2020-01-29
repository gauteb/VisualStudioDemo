namespace VisualStudioDemo
{
    public class UserDb
    {
        public bool validateUser(string username, string password)
        {
            return username + "123" == password;
        }
    }
}
