using AutoMapper;
using BookStoreLap.Books;

namespace BookStoreLap
{
    public class BookStoreLapApplicationAutoMapperProfile : Profile
    {
        public BookStoreLapApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
        }
    }
}
