using System;
using CQRSMediatrExample.Domains.Queries.Itens.Responses;
using MediatR;

namespace CQRSMediatrExample.Domains.Queries.Itens.Requests
{
    public class GetItemRequest : IRequest<GetItemResponse>
    {
        public Guid Id { get; set; }
    }
}