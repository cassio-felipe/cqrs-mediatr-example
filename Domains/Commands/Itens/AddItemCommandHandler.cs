using System.Threading;
using System.Threading.Tasks;
using CQRSMediatrExample.Domains.Commands.Itens.Requests;
using CQRSMediatrExample.Domains.Commands.Itens.Responses;
using CQRSMediatrExample.Domains.Entities;
using MediatR;

namespace CQRSMediatrExample.Domains.Commands.Itens
{
    public class AddItemCommandHandler : IRequestHandler<CreateItemCommandRequest, CreateItemCommandResponse>
    {
        public async Task<CreateItemCommandResponse> Handle(CreateItemCommandRequest request, CancellationToken cancellationToken)
        {
            var item = new Item(request.ItemName, request.ItemCode);

            var result = new CreateItemCommandResponse
            {
                Id = item.Id,
                ItemName = request.ItemName,
                ItemCode = request.ItemCode
            };

            return result;
        }
    }
}