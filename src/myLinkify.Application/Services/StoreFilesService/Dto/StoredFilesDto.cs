using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using myLinkify.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.StoreFilesService.Dto
{
    [AutoMap(typeof(StoredFile))]
    public class StoredFilesDto : EntityDto<Guid>
    {
        public  string FileType { get; set; }
        public  string FileName { get; set; }
        public  string FileDescription { get; set; }
    }
}
