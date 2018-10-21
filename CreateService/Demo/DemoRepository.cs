using DMSModel;
using System.Data.Entity;
using System.Linq;

namespace DMS.Repository
{
    public class DemoRepository : GenericRepository<Demo_Class>, IDemoRepository
    {
        public DemoRepository(DbContext context) : base(context)
        {

        }
         

        public Demo_Class GetById(demoIdType id)
        {
            return _dbset.Where(x => x.demoId == id).FirstOrDefault();
        }
    }
}
