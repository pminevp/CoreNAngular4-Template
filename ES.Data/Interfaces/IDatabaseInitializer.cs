using System.Threading.Tasks;

namespace ES.Data.Interfaces
{
    public interface IDatabaseInitializer
    {
        Task SeedAsync();
    }
}
