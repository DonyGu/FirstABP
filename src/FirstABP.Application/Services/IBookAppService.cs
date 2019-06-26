using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FirstABP.Services
{
    public interface IBookAppService : IAsyncCrudAppService<BookDto, Guid,
        PagedAndSortedResultRequestDto, CreateUpdateBookDto, CreateUpdateBookDto>
    {

    }
}
