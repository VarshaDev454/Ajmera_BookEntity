using AutoMapper;
using BookEntity.ViewModel;
using DataAccessLayer.Models;

namespace BookEntity.Mapper
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Book, BookViewModel>()
                .ForMember(x => x.Id, y => y.MapFrom(x => x.Id))
                .ForMember(x => x.Name, y => y.MapFrom(x => x.Name))
                .ForMember(x => x.AuthorName, y => y.MapFrom(x => x.AuthorName))
                .ReverseMap();
        }
    }
}
