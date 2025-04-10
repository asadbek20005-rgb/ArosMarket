using Microsoft.AspNetCore.Http;

namespace ArosMarket.Core.Models.Content;

public class AddContentModel
{
    public IFormFile file { get; set; }
}
