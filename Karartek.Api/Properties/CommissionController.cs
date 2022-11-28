using Karartek.Business.Abstract;
using Karartek.Business.Concrete;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Karartek.Api.Properties


{
    [Route("api/[controller]")]
    [ApiController]
    public class CommissionController : ControllerBase
    {
        private ICommissionService _commissionService;

        public CommissionController(ICommissionService commissionService)
        {
            _commissionService = commissionService;
        }

        [HttpGet("GetAll")]
        public CommissionResponseDto GetAll()
        {
            var commisionToSearch = _commissionService.GetCommission();
            return commisionToSearch;
        }

        [HttpGet("GetById/{{id}}")]
        public Commission GetById(int id)
        {
            var commisionToSearch = _commissionService.GetCommissionById(id);
            return commisionToSearch;
        }
    }
}
