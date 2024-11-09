namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        // all props must be public so EF can work with them
        // in EF class is table, prop is column
        public required string UserName { get; set; }
    }
}