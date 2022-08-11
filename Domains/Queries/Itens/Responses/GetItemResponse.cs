using System;

namespace CQRSMediatrExample.Domains.Queries.Itens.Responses
{
    public class GetItemResponse
    {
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        
    }
}