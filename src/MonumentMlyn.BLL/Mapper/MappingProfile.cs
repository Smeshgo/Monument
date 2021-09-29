using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.DTO.ArticlePhoto;
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
            CreateMap<Article, ArticleDto>();
            CreateMap<ArticleDto, Article>();

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

            CreateMap<Customer, CustomerDto>();
            CreateMap<Customer, CustomerDto>();

        }
    }
}