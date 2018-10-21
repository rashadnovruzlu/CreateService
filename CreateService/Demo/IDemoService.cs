using DMS.Model.DTO;
using DMS.Service.EntityService;
using DMSModel;
using System.Collections.Generic;

namespace DMS.Service
{
    public interface IDemoService : IEntityService<Demo_Class>
    {
        Demo_Class GetById(demoIdType Id); 

    }
}
