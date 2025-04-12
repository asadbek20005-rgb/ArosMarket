namespace ArosMarket.Core.Dtos;

public class BaseDto
{

    public int Id { get; set; }

    public string FullName { get; set; }


    public string ShortName { get; set; }

    public string Code { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; }
}
