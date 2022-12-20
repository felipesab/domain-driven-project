using AutoMapper;
using DomainDrivenProject.Domain.Entities;
using DomainDrivenProject.MVC.ViewModels;

namespace DomainDrivenProject.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClientViewModel, Client>();
            Mapper.CreateMap<ProductViewModel, Product>();
        }
    }
}