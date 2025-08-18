namespace DapperTask.DTO
{
    public class AddressModelDTO
    {
        // Id is primary key of address table auto incremented
        public string AddressType { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Pincode { get; set; } = null!;
    }
}
