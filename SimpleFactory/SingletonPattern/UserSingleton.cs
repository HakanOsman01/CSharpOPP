using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class UserSingleton
    {
        private static UserSingleton instance;
        private static object lockObject=new object();
        private UserSingleton() { }
        public static UserSingleton Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new UserSingleton();
                        }


                    }

                }
               
                return instance;
            }
        }
        public string Name { get; set; }
        public string Password { get; set; }  
        public void ChangePassword(string newPassword)
        {
            this.Password = newPassword;

        }

    }
}
