namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string FullName { get; set; }

        public string Email { get; set; }

        public string AvatarUrl { get; set; } = "/images/default.jpg";
    }
}