using System.Collections.Generic;
using System.Linq;
using DMS.Model.DTO;
using DMS.Repository;
using DMS.Service.EntityService;
using DMSModel;
using Repository;

namespace DMS.Service
{
    public class DemoService : EntityService<Demo_Class>, IDemoService
    {
        IUnitOfWork _unitOfWork;
        IDemoRepository _demoRepository;

        public DemoService(IUnitOfWork unitOfWork, IDemoRepository ddemoRepository)
            : base(unitOfWork, ddemoRepository)
        {
            _unitOfWork = unitOfWork;
            _demoRepository = ddemoRepository;
        }
 
        public Demo_Class GetById(demoIdType Id)
        {
            return _demoRepository.GetById(Id);
        }

        
    }
}
