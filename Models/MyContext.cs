using Microsoft.EntityFrameworkCore;


namespace C_Project.Models
{

    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<User> Users { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }
        public DbSet<FriendList> FriendLists { get; set; }
        public DbSet<DirectMessage> DirectMessages { get; set; }
    }


}