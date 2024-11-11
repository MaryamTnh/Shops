using Domain.Entity;
using Domain.Interface;
using Microsoft.VisualBasic;

namespace Shop.Controllers.Service
{
    public class SliderService : ISliderService
    {
        private readonly ISliderService _sliderService;
        public SliderService(ISliderService sliderServuce)
        {
            _sliderService = sliderServuce;
        }
        public async Task Add(SliderEntity slider)
        {
            await _sliderService.Add(slider);
        }

        public async Task Delete(SliderEntity slider)
        {
            await _sliderService.Delete(slider);
        }

        public async Task<IEnumerable<SliderEntity>> GetAll()
        {
            return await _sliderService.GetAll();   
        }

        public async Task<SliderEntity> GetById()
        {
            return await _sliderService.GetById();
        }

        public async Task Update(SliderEntity slider)
        {
            await _sliderService.Update(slider);
        }
    }
}
