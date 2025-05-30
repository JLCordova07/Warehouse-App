namespace Inventario.api.Models
{
    public class WarehouseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<RackModel>? Racks { get; set; }
        public WarehouseModel()
        {
            
        }
        public WarehouseModel(int id, string name, string? description, List<RackModel>? racks)
        {
            Id = id;
            Name = name;
            Description = description;
            Racks = racks;
        }
    }
}
