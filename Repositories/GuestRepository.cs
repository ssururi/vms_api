using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMSApi.Interfaces;
using VMSApi.Models;

namespace VMSApi.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        private readonly AppDbContext _context;

        public GuestRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CreateGuest(Guest guest)
        {
            if (guest == null) {
                throw new ArgumentNullException(nameof(guest));
            }

            _context.Guests.Add(guest);
        }

        public IEnumerable<Guest> GetAllGuests()
        {
            return _context.Guests.ToList();
        }

        public Guest GetGuestById(Guid id)
        {
            return _context.Guests.SingleOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
             return (_context.SaveChanges() >= 0);
        }
    }
}