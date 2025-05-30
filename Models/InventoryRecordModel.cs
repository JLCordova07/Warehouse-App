namespace Inventario.api.Models
{
    public class InventoryRecordModel
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int ItemCategoryId { get; set; }
        public string WarehouseCodeName { get; set; }
        public string RackCodeName { get; set; }
        public string LevelCodeName { get; set; }
        public string SectionCodeName { get; set; }
        public string? ContainerCodeName { get; set; }
        public decimal Quantity { get; set; }
        public InventoryRecordModel()
        {
            
        }
        public InventoryRecordModel(int id, int itemId, int itemCategoryId, string warehouseCodeName, string rackCodeName, string levelCodeName, string sectionCodeName, string? containerCodeName, decimal quantity)
        {
            Id = id;
            ItemId = itemId;
            ItemCategoryId = itemCategoryId;
            WarehouseCodeName = warehouseCodeName;
            RackCodeName = rackCodeName;
            LevelCodeName = levelCodeName;
            SectionCodeName = sectionCodeName;
            ContainerCodeName = containerCodeName;
            Quantity = quantity;
        }
    }
}
