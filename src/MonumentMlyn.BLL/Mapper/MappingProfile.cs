using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Paging;

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

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Worker, WorkerDto>();
            CreateMap<WorkerDto, Worker>();

            CreateMap<Customer, CustomerDto>();
            CreateMap<Customer, CustomerDto>();

            CreateMap<Salary, SalaryDto>();
            CreateMap<SalaryDto, Salary>();

            CreateMap<PagedList<Photo>, PagedList<PhotoDto>>();
            CreateMap<PagedList<PhotoDto>, PagedList<Photo>>();


        }
    }
}