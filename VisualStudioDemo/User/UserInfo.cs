using System;

namespace VisualStudioDemo
{
    public class UserInfo
    {
        public static void PrintInfo(User user)
        {
            Console.Write("Denne brukeren har brukernavn: " + user.Username);
        }
    }
}
