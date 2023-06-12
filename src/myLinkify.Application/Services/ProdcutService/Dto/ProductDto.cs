using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using myLinkify.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.ProdcutService.Dto
{
    [AutoMap(typeof(Product))]
    public class ProductDto : EntityDto<Guid>
    {
        public  string ProductName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  string ProductDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProductCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Price { get; set; }
    }
}
