using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsYonetimSistemi.Entity.Dto
{
    public class DtoPersonelToken
    {
        public DtoLoginPersonel DtoLoginPersonel { set; get; }
        public object AccessToken { get; set; }
    }
}
