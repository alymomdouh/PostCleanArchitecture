using AutoMapper;
using PostCleanArchitecture.Application.Features.Posts.Commands.CreatePost;
using PostCleanArchitecture.Application.Features.Posts.Commands.UpdatePost;
using PostCleanArchitecture.Application.Features.Posts.Queries.GetPostDetail;
using PostCleanArchitecture.Application.Features.Posts.Queries.GetPostsList;
using PostCleanArchitecture.Domain;

namespace PostCleanArchitecture.Application.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, GetPostsListViewModel>().ReverseMap();
            CreateMap<Post, GetPostDetailViewModel>().ReverseMap();
            CreateMap<Post, UpdatePostCommand>().ReverseMap();
            CreateMap<Post, CreatePostCommand>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
