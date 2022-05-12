using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.AuthServer.Core.DTOs
{
    public interface ClientLoginDTO
    {
        public string ClientId { get; set; }
        public string ClientSecret{ get; set; }

    }
}
