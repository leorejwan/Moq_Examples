using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moq_Examples
{
    public interface IPartner
    {
        Partner GetPartner(int partnerId);
    }
}
