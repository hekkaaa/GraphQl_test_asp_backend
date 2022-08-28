using GraphQlServer.Context;


namespace GraphQlServer.Repository
{
    public class AccountRepository 
    {
        private readonly ApplicationContext _context;
        public AccountRepository(ApplicationContext context)
        {
            _context = context;
        }


        public bool AddNewAccount()
        {
            _context.SaveChanges();
            
            return true;
        }
    }
}
