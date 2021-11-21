using System;
using GiftSuggestion.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace GiftSuggestion.Repository
{
    public class GiftImplementation : IGiftRepository
    {

        private string _configuration;

        public GiftImplementation(IConfiguration configuration)
        {
            _configuration = configuration.GetConnectionString("ConnectionsStrings");            
        }


        public async Task<int> Gravar(GiftModel gift)
        {
            var rows = 0;
            
            using (var con = new SqlConnection (_configuration))
            {
                rows = await con.ExecuteAsync("insert into registro (nomeproduto, categoria, subcategoria, publicoalvo) values(@Nome, @Categoria, @Subcategoria, @PublicoAlvo)",gift);
            }

            return rows;
        }
    }
}
