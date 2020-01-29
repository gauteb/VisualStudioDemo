namespace VisualStudioDemo
{
    public class Login : ILogin
    {
        UserDb userDb = new UserDb();
        public bool LoginUser(string username, string password) 
        {
            var isUser = userDb.validateUser(username, password);

            return isUser;
        }

        public User RegisterUser(User user)
        {
            user.Password = user.Username + "123";

            return user;
        }
    }
}
