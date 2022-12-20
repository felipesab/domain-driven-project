using AutoMapper;
using DomainDrivenProject.Domain.Entities;
using DomainDrivenProject.MVC.ViewModels;

namespace DomainDrivenProject.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Client, ClientViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
        }
    }
}