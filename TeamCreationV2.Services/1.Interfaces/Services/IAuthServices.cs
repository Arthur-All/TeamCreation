using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCreationV2.Core.Entites;
using TeamCreationV2.Domain.DTOs;

namespace TeamCreationV2.Services.Interfaces.Services
{
    public interface IAuthServices
    {
        Task<Persons> Authenticate(PersonLogin personlogin);
    }
}
