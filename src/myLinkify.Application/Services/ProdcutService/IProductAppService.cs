using Abp.Application.Services;
using myLinkify.Services.LocationService.Dto;
using myLinkify.Services.ProdcutService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.ProdcutService
{
    public interface IProductAppService : IApplicationService
    {
        Task<ProductDto> CreateAsync(ProductDto input);
        Task<ProductDto> GetAsync(Guid id);
        Task<List<ProductDto>> GetAllAsync();
        Task<ProductDto> UpdateAsync(ProductDto input);
        Task Delete(Guid id);
    }
}
