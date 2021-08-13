using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.BLL.Mapper
{
    /// <summary>
    /// Class for mapping profile.
    /// </summary>
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Appointment, AppointmentDto>();
            CreateMap<AppointmentDto, Appointment>();

            CreateMap<Article, ArticleDto>();
            CreateMap<ArticleDto, Article>();

            CreateMap<CategoryMaterial, CategoryMaterialDto>();
            CreateMap<CategoryMaterialDto, CategoryMaterial>();

            CreateMap<CategoryPhoto, CategoryPhotoDto>();
            CreateMap<CategoryPhotoDto, CategoryPhoto>();

            CreateMap<Material, MaterialDto>();
            CreateMap<MaterialDto, Material>();

            CreateMap<Monument, MonumentDto>();
            CreateMap<MonumentDto, Monument>();

            CreateMap<Photo, PhotoDto>();
            CreateMap<PhotoDto, Photo>();

            CreateMap<Role, RoleDto>();
            CreateMap<RoleDto, Role>();

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Worker, WorkerDto>();
            CreateMap<WorkerDto, Worker>();

            CreateMap<Customer, СustomerDto>();
            CreateMap<Customer, СustomerDto>();

        }


    }
}