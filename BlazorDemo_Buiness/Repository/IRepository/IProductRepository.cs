using BlazorDemo.BlazorDemo_DataAccess;
using BlazorDemo.DemoModels;

namespace BlazorDemo.BlazorDemo_Buiness.Repository.IRepository;

public interface IProductRepository
{
    public Task<ProductDTO> Create(ProductDTO objDTO);

    public Task<ProductDTO> Update(ProductDTO objDTO);

    public Task<int> Delete(int id);

    public Task<ProductDTO> Get(int id);

    public Task<IEnumerable<ProductDTO>> GetAll();
}
