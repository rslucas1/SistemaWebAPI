using API.Rejected.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Rejected.Repositories
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> GetClientesAsync();
        Task<Cliente> GetClienteByIdAsync(int id);
        Task<int> SaveAsync(Cliente novoCliente);
        Task<int> UpdateClienteAsync(Cliente atualizaCliente);
        Task<int> DeleteCliente(int id);
    }
}
