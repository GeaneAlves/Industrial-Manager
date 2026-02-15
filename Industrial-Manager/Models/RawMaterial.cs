namespace IndustrialManager.Models;

public class RawMaterial {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal StockQuantity { get; set; }
    public ICollection<ProductMaterial> ProductMaterials { get; set; }
}