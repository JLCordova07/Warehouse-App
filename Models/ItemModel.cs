namespace Inventario.api.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? CodeName { get; set; }
        public string? Description01 { get; set; }
        public string? Description02 { get; set; }
        public int SupplierId { get; set; }
        public string? SupplierCodeName { get; set; }
        public int ItemStatusId { get; set; }
        public ItemModel()
        {

        }
        public ItemModel(int id, string name, string? codeName, string? description01, string? description02, int supplierId, string? supplierCodeName, int itemStatusId)
        {
            Id = id;
            Name = name;
            CodeName = codeName;
            Description01 = description01;
            Description02 = description02;
            SupplierId = supplierId;
            SupplierCodeName = supplierCodeName;
            ItemStatusId = itemStatusId;
        }
    }
}
