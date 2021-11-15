using GiftSuggestion.Models;
using System;
using System.Threading.Tasks;

namespace GiftSuggestion.Business.Implementations
{
    public class GiftBusinessImplementations : IGiftBusiness
    {
        //Criar construtor e injetar o repository

        public async Task<GiftModel> Cadastrar(GiftModel model)
        {
            throw new NotImplementedException();//chamar o método de gravr do repository e retornar o dado gravado
        }
        
    }
}
