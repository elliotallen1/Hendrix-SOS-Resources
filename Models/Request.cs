namespace SOSResources.Models
{

    public enum RequestStatus
    {
        Pending,
        Approved,
        Denied
    }

    public class Request
    {
        public int Id { get; set; }
        public bool NeedWithin24Hours { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public RequestStatus Status { get; set; } = RequestStatus.Pending;

        public int ResourceId { get; set; }
        public Resource Resource { get; set; }
    }
}