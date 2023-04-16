using System.Text.Json.Serialization;

namespace SchemaTesting.Validation;

public record CreateCustomerCommand
{
    [JsonPropertyName("firstName")]
    public string? FirstName { get; init; }
    
    [JsonPropertyName("lastName")]
    public string? LastName { get; init; }
    
    [JsonPropertyName("address")]
    public string? Address { get; init; }

    public bool IsValid()
    {
        if (string.IsNullOrEmpty(this.Address))
        {
            return false;
        }

        var addressParts = this.Address.Split(',');

        if (addressParts.Length != 5) return false;

        return true;
    }
}

