using ETickets2023.Data.Base;
using ETickets2023.Models;
using Microsoft.EntityFrameworkCore;

namespace ETickets2023.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context): base(context) {}
    }
}
