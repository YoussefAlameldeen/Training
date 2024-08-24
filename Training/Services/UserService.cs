using Training.Models;

namespace Training.Services
{
    public class UserService : IUserService
    {
        protected readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context =context;
        }
        
        public void Register(ModelView modelView) 
        {
            User user = new User
            {
                Name = modelView.Name,
                Email = modelView.Email,
                Password = modelView.Password,
            };
            _context.user.Add(user);
            _context.SaveChanges();
        }

    }
}



