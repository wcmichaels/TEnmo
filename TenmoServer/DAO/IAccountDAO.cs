using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TenmoServer.Models;

namespace TenmoServer.DAO
{
    public interface IAccountDAO
    {
        Account GetAccountByUserId(int user_id);
        List<DisplayAccount> GetAllDisplayAccounts();
    }
}
