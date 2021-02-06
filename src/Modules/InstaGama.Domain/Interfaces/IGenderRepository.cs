using InstaGama.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InstaGama.Domain.Interfaces
{
    public interface IGenderRepository
    {
        Task<Gender> GetByIdAsync(int id);
    }
}
