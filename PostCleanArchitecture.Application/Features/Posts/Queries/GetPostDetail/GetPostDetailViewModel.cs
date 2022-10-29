using PostCleanArchitecture.Application.Features.Posts.Queries.GetPostsList;
using System;

namespace PostCleanArchitecture.Application.Features.Posts.Queries.GetPostDetail
{
    public class GetPostDetailViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public CategoryDto Category { get; set; }
    }
}
