using Microsoft.AspNetCore.Mvc.Rendering;

namespace RealEstate.Model.ViewModel.EstatesViewModel
{
    public class EstateViewModel
    {
        public EstateModel? Estate { get; set; }

        #region Upload
        public IFormFile ImUp { get; set; }
        #endregion

        #region Category
        public SelectList CategoryOptions{ get; set; }

        public string? SelectedCategory { get; set; }
        public object ImgUp { get; internal set; }
        #endregion
    }
}
