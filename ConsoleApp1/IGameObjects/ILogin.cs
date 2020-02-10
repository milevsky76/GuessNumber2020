using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IGameObjects
{
    interface ILogin
    {
        /// <summary>
        /// Return null if incorect login or password
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        User Login(string userName, string password);
    }
}
