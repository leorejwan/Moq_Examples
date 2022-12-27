using Moq;
using Moq_Examples;

namespace Moq_ExamplesTest
{
    public class PsrtnersClubTest
    {
        private Club _target;
        private Mock<IPartner> _mock;

        [Fact]
        public void CalculateShippingValueTest()
        {
            _mock = new Mock<IPartner>();
            _target = new Club(_mock.Object);
            var partner = new Partner()
            {
                PartnerID = 1,
                FirstName = "Jose Carlos",
                LastName = "Macoratti",
                Age = 45,
                Limit = 5,
            };
            _mock.Setup(x => x.GetPartner(It.IsAny<int>())).Returns(partner);
            int socioID = 1;
            double esperado = 14;
            double obtido = _target.CalculateShippingValue(socioID);
            Assert.Equal(esperado, obtido);
        }
    }
}