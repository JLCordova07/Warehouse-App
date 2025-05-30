namespace Inventario.api.Models
{
    public class RackModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string CodeName { get; set; }
        public string? Description { get; set; }
        public int WarehouseId { get; set; }
        public List<LevelModel>? Levels { get; set; }
        public RackModel(int id, string? name, string? description, string codeName, int warehouseId, List<LevelModel>? levels)
        {
            Id = id;
            Name = name;
            CodeName = codeName;
            Description = description;
            WarehouseId = warehouseId;
            Levels = levels;
        }
        public RackModel()
        {

        }
    }
}
