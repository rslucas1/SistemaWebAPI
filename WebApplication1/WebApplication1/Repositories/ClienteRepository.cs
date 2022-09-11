using API.Rejected.Context;
using API.Rejected.Domain.Entities;
using API.Rejected.Repositories;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Rejected.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private DbSession _db;

        public ClienteRepository(DbSession dbSession)
        {
            _db = dbSession;
        }
                

        public async Task<List<Cliente>> GetClientesAsync()
        {
            using (var conn = _db.Connection)
            {
                string query = @"SELECT * FROM CLIENTE";

                List<Cliente> clientes = (await conn.QueryAsync<Cliente>(sql: query)).ToList();

                return clientes;
            }
        }

        public async Task<Cliente> GetClienteByIdAsync(int id)
        {
            using (var conn = _db.Connection)
            {
                string query = @"select * from CLIENTE where id=@id";

                Cliente cliente = await conn.QueryFirstOrDefaultAsync<Cliente>(sql: query, param: new { id });
                
                return cliente;
            }
            
        }

        public async Task<int> SaveAsync(Cliente novoCliente)
        {
            using (var conn = _db.Connection)
            {
                string command = @"INSERT INTO CLIENTE (id, razaoSocial,cnpj)
                                VALUES (@id, @razaoSocial,@cnpj)";

                var result = await conn.ExecuteAsync(sql: command, param:novoCliente);

                return result;
            }
        }

        public Task<int> UpdateClienteAsync(Cliente atualizaCliente)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteCliente(int id)
        {
            throw new NotImplementedException();
        }
    }
}
