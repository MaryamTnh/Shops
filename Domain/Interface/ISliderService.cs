using Domain.Entity;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface ISliderService
    {
        Task<SliderEntity> GetById();
        Task<IEnumerable<SliderEntity>> GetAll();
        Task Add(SliderEntity slider);
        Task Update(SliderEntity slider);
        Task Delete(SliderEntity slider);
    }
}
