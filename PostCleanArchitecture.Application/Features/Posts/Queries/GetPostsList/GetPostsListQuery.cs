using MediatR;
using System.Collections.Generic;

namespace PostCleanArchitecture.Application.Features.Posts.Queries.GetPostsList
{
    public class GetPostsListQuery : IRequest<List<GetPostsListViewModel>>
    {

    }
}
