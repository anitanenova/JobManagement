namespace JobManagement.Models.Account
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Resources;
    using User;

    public class RegistrationUserViewModel: UserViewModel, IValidatableObject
    {
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        [Display(Name = "Password", ResourceType = typeof(AccountResource))]
        public string Password { get; set; }


        [Display(Name = "ConformPassword", ResourceType = typeof(AccountResource))]
        [Compare(nameof(Password), ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        public string ConfirmPassword { get; set; }
        
        [Display(Name = "AgreeingGeneralTerms")]
        public bool AgreeingGeneralTerms { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!AgreeingGeneralTerms)
            {
                yield return new ValidationResult(AccountResource.NotAgreeWithGeneralTermsMsg, new[] { nameof(AgreeingGeneralTerms) });
            }
        }
    }
}