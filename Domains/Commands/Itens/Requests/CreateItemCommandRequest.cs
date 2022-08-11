using CQRSMediatrExample.Domains.Commands.Itens.Responses;
using MediatR;

namespace CQRSMediatrExample.Domains.Commands.Itens.Requests
{
    public class CreateItemCommandRequest : IRequest<CreateItemCommandResponse>
    {
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
    }
}