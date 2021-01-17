namespace JobManagement
{
    using AutoMapper;
    using Models;
    using Models.Account;
    using Models.BusinessUser;
    using Models.Models;
    using Models.User;
    using UserViewModel = Models.User.UserViewModel;

    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<User, RegistrationUserViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<BusinessUser, BusinessUserViewModel>().ReverseMap();
            CreateMap<BusinessUser, BusinessUserInformationViewModel>().ReverseMap();
            CreateMap<BusinessUser, RegistrationBusinessUserViewModel>().ReverseMap();
            CreateMap<UpdateUserViewModel, User>().ReverseMap();
            CreateMap<UserInformationViewModel, User>().ReverseMap();
            CreateMap<BusinessUser, UpdateBusinessUserViewModel>().ReverseMap();
            CreateMap<User, UserGalleryViewModel>().ReverseMap();
        }
    }
}
