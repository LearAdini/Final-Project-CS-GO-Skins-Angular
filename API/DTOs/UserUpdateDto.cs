namespace API.DTOs
{
    public class UserUpdateDTO
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}