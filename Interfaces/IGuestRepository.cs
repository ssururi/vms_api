using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMSApi.Models;

namespace VMSApi.Interfaces
{
    public interface IGuestRepository
    {
        bool SaveChanges();
        IEnumerable<Guest> GetAllGuests();
        void CreateGuest(Guest guest);
        Guest GetGuestById(Guid id);
    }
}