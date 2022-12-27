using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moq_Examples
{
    public class Club
    {
        private readonly IPartner _partner;
        public Club(IPartner partner)
        {
            this._partner = partner;
        }
        public double CalculateShippingValue(int partnerID)
        {
            double partnerShippingValue = 0;
            Partner partner = _partner.GetPartner(partnerID);
            partnerShippingValue = 10 + partner.Limit * 0.8;
            return partnerShippingValue;
        }
    }
}
