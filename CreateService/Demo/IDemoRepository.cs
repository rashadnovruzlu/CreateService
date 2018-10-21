using DMSModel;

namespace DMS.Repository
{
    public interface IDemoRepository : IGenericRepository<Demo_Class>
    {
        Demo_Class GetById(demoIdType id);
    }
}
