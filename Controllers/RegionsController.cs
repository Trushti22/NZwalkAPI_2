using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZwalks.API.Data;
using NZwalks.API.Models.Domain;

namespace NZwalks.API.Controllers
{   //https://localhost:portnumber/api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;

        public RegionsController(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET ALL REGIONS
        // GET: https://localhost:portnumber/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            //manual
            /*var regions = new List<Region>
            {
                new Region
                {
                    Id =Guid.NewGuid(),
                    Name="Auckland Region",
                    Code="AKL",
                    RegionImageUrl="https://www.pexels.com/video/18982554/"
                },
                new Region
                {
                    Id =Guid.NewGuid(),
                    Name="wellington Region",
                    Code="WLG",
                    RegionImageUrl="https://www.pexels.com/video/18982554/"
                },
            };*/
            var regions = dbContext.Regions.ToList();
            return Ok(regions);
        }
    }
}
