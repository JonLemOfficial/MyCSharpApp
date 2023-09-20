namespace MyCSharpApp.WebAPI
{
    public class User
    {
        public int _id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime Time { get; set; }
        public string Genre { get; set; }
        public int Age { get; set; }
        public bool Verified { get; set; }
    }
}
