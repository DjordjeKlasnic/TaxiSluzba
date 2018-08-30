using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiSluzba_backend.Models;

namespace TaxiSluzba_backend.Repository.RepositoryInterface
{
    public interface IUserRepository
    {
        List<User> ReadUsers();   
    }
}
