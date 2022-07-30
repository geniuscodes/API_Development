namespace API_Development.Models
{
    public class Service : BaseEntity
    {
        public int Id { get; set; }

        //List of ServiceTypes
        public List<ServiceType> TypeOfService { get; set; }

        //Later call the API location API
        public string Place { get; set; }

        public string notes { get;set }

    }
}
