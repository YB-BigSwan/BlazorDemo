using System.Collections;

namespace BlazorDemo.DemoModels.BlazorModels;

public class Product
{
    public int id { get; set; }
    
    public string name { get; set; }
    
    public double price { get; set; }
    
    public bool isActive { get; set; }
    
    public List<ProductProperties> ProductProperties { get; set; }
}