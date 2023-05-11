namespace ASPPTraining1.Models.ORM
{
    public class WebUser : BaseEntitiy
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int AdressId { get; set; }
        public Adress Adress { get; set; }

    }
}
