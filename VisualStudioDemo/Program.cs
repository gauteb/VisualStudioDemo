using System.Collections.Generic;
using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;


namespace VisualStudioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            User alexander = new User() { Username = "Alexander" };
            User amund = new User() { Username = "Amund" };
            User daniel = new User() { Username = "Daniel" };

            var userList = new List<User>()
            {
                alexander,
                amund,
                daniel,
            };

            UserInfo.PrintInfo(alexander);

            ILogin login = new Login();

            foreach (var user in userList)
            {
                login.RegisterUser(SetEmpty(user));

                if (user.Username == "Amund")
                {
                    //do something
                }

                PeekDefinition.Peek();
            }

            User SetEmpty(User user)
            {
                if (user.Password is null)
                {
                    user.Password = string.Empty;
                }

                return user;
            }

            //if(Debugger.IsAttached)
            //{
            //    Debugger.Break();
            //    //do something
            //}

            //TODO: Show Task List (dont forget settings)
        }
    }
}
