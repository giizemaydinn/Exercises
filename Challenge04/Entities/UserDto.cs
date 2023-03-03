namespace Challenge04.Entities
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Status { get; set; }
    }

    public enum UserStatusEnum
    {
        Active = 0,
        Inactive = 1
    }
}
