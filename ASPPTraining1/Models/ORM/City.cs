namespace ASPPTraining1.Models.ORM
{
    public class City : BaseEntitiy
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
