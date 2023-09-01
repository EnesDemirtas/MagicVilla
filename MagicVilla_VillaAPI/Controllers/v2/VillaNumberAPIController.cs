using AutoMapper;
using MagicVilla_VillaAPI.Logging;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers.v2
{
    // [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/VillaNumberAPI")]
    [ApiController]
    [ApiVersion("2.0")]
    public class VillaNumberAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IVillaNumberRepository _villaNumberRepository;
        private readonly IVillaRepository _villaRepository;
        private readonly ILogging _logger;
        private readonly IMapper _mapper;
        public VillaNumberAPIController(ILogging logger, IVillaNumberRepository villaNumberRepository, IMapper mapper,
            IVillaRepository villaRepository)
        {
            _logger = logger;
            _villaNumberRepository = villaNumberRepository;
            _mapper = mapper;
            _response = new();
            _villaRepository = villaRepository;
        }

        // [MapToApiVersion("2.0")]
        [HttpGet("GetString")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
