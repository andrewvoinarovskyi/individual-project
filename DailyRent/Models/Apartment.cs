public class Apartment
{
    public int Id { get; set; }
    public int Rooms { get; set; }
    public int Area { get; set; }
    public int Floor { get; set; }
    public string Address { get; set; }
    public int Beds { get; set; }
    public string Description { get; set; }

    public Owner Owner { get; set; }
    public int OwnerId { get; set; }
    public Type Type { get; set; }
    public int TypeId { get; set; }
}