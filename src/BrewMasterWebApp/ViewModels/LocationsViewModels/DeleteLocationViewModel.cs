using System.ComponentModel.DataAnnotations;
using BrewMasterWebApp.Models;

namespace BrewMasterWebApp.ViewModels.LocationsViewModels
{
    public class DeleteLocationViewModel
    {
        public Location Location { get; set; }
        
        public bool Success { get; set; }

        public string Message { get; set; }
        
        public string BreweryName { get; set; }
       
       [Required]
        public string LocationId { get; set; }

        public bool Deleted { get; set; }

        public string UserFirstName { get; set; }
    }
}