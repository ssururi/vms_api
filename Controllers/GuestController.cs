using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VMSApi.Dtos;
using VMSApi.Interfaces;
using VMSApi.Models;

namespace VMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly ILogger<GuestController> _logger;
        private readonly IGuestRepository _guestRepository;
        private readonly IMapper _mapper;
        
        public GuestController(ILogger<GuestController> logger, IGuestRepository guestRepository, IMapper mapper)
        {
            _logger = logger;
            _guestRepository = guestRepository;
            _mapper = mapper;
        }  

        [HttpGet]
        public ActionResult<IEnumerable<GuestReadDto>> GetAllGuests() {
            var guestItem = _guestRepository.GetAllGuests();
            return Ok(_mapper.Map<IEnumerable<GuestReadDto>>(guestItem)); 
        }    

        [HttpGet("{id}", Name = "GetGuestById")]
        public ActionResult<GuestReadDto> GetGuestById(Guid id)
        {
            var guestItem = _guestRepository.GetGuestById(id);
            if (guestItem != null)
            {
                return Ok(_mapper.Map<GuestReadDto>(guestItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<GuestReadDto> CreateGuest(GuestWriteDto guestWriteDto)
        {
             var guestModel = _mapper.Map<Guest>(guestWriteDto);
            _guestRepository.CreateGuest(guestModel);
            _guestRepository.SaveChanges();

            var guestReadDto = _mapper.Map<GuestReadDto>(guestModel);

            return CreatedAtRoute(nameof(GetGuestById), new { Id = guestReadDto.Id}, guestReadDto);
        } 
    }
}