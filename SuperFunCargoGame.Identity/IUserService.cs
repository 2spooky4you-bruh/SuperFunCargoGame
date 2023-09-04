using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFunCargoGame.Identity
{
    public interface IUserService
    {

        bool Login(string username, string password);
    }
}
