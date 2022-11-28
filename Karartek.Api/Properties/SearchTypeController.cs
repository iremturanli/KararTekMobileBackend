using Karartek.Business.Abstract;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Karartek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchTypeController : ControllerBase
    {
        private ISearchTypeService _searchTypeService;

        public SearchTypeController(ISearchTypeService searchTypeService)
        {
            _searchTypeService = searchTypeService;
        }

        [HttpGet("GetAll")]
        public SearchTypeResponseDto GetAll()
        {
            var searchTypeToSearch = _searchTypeService.GetSearchTypes();
            return searchTypeToSearch;
        }

        [HttpGet("GetById/{{id}}")]
        public SearchType GetById(int id)
        {
            var searchTypeToSearch = _searchTypeService.GetSearchTypeById(id);
            return searchTypeToSearch;
        }

        [HttpPost("Add")]
        public ActionResult Add(SearchTypeDto searchTypeDto)
        {
            var searchTypeToAdd = _searchTypeService.AddSearchType(searchTypeDto);
            if (searchTypeToAdd)
            {
                return Ok(searchTypeToAdd);

            }
            else
            { return BadRequest("Adding Failed"); }

        }

        [HttpPost("Update")]
        public ActionResult Update(SearchType searchType)
        {
            var searchTypeToUpdate = _searchTypeService.UpdateSearchType(searchType);
            if (searchTypeToUpdate)
            {
                return Ok(searchTypeToUpdate);

            }
            else
            { return BadRequest("Updating Failed"); }

        }

        [HttpPost("Delete")]
        public ActionResult Delete(SearchType searchType)
        {
            var searchTypeToDelete = _searchTypeService.DeleteSearchType(searchType);
            if (searchTypeToDelete)
            {
                return Ok(searchTypeToDelete);

            }
            else
            { return BadRequest("Deleting Failed"); }

        }
    }
}

