using RealEstate.Model;

namespace RealEstate.Models.ViewModels.EstatesViewModels
{
    public class EstateDetailsViewModel
    {
        public EstateModel Estate { get; set; }
        public List<EstateModel> SuggestedProducts { get; set; }
    }
} 
