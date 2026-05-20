namespace Domain;

public class Pizza (string flavour)
{
    public required string Flavour { get; set; } = flavour;
    public required int Slices { get; set; } = 6;
}