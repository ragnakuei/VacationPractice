using DataAccessLayer.EF;

namespace DataAccessLayer
{
    public static class DbInitializer
    {
        public static void Initialize(VacationPracticeDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}