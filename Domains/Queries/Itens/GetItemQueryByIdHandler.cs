using System.Threading;
using System.Threading.Tasks;
using CQRSMediatrExample.Domains.Queries.Itens.Requests;
using CQRSMediatrExample.Domains.Queries.Itens.Responses;
using MediatR;

namespace CQRSMediatrExample.Domains.Queries.Itens
{
    public class GetItemQueryByIdHandler : IRequestHandler<GetItemRequest, GetItemResponse>
    {
        public Task<GetItemResponse> Handle(GetItemRequest request, CancellationToken cancellationToken)
        {
            //Busca no banco o objeto pelo id, cria o response e retorna.
            
           var result = new GetItemResponse
            {
                Id = request.Id,
                ItemName = "Nome Fcticio",
                ItemCode = "Code Ficticio"
            };
            
            return Task.FromResult(result);
        }
        
    }
}