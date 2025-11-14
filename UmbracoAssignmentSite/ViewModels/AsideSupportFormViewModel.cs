using System.ComponentModel.DataAnnotations;

namespace UmbracoAssignmentSite.ViewModels
 {
    public class AsideSupportFormViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null!;

    }
 }

