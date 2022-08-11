using System;

namespace CQRSMediatrExample.Domains.Commands.Itens.Responses
{
    public class CreateItemCommandResponse
    {
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
    }
}