using BlazorDemo.DemoModels;
namespace BlazorDemo.BlazorDemo_Buiness.Repository.IRepository;

public interface IProductPriceRepository
{
    public Task<ProductPriceDTO> Create(ProductPriceDTO objDTO);
    public Task<ProductPriceDTO> Update(ProductPriceDTO objDTO);
    public Task<int> Delete(int id);
    public Task<ProductPriceDTO> Get(int id);
    public Task<IEnumerable<ProductPriceDTO>> GetAll(int? Id=null);
}