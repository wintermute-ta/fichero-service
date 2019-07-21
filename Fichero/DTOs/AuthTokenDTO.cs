using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fichero.DTOs
{
    public class AuthTokenDTO
    {
        public string DateCreated { get; set; }
        public string Description { get; set; }
        public string Token { get; set; }
        public int Id { get; set; }
        public string LastUsed { get; set; }
        public string LastUsedIp { get; set; }
    }
}
