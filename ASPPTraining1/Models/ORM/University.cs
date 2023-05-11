namespace ASPPTraining1.Models.ORM
{
    public class University:BaseEntitiy
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
