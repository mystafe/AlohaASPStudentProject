using System.Xml.Linq;

namespace ASPPTraining1.Models.ORM
{
    public class Adress:BaseEntitiy
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string Description { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
