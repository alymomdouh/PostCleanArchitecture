﻿using MediatR;
using System;

namespace PostCleanArchitecture.Application.Features.Posts.Queries.GetPostDetail
{
    public class GetPostDetailQuery : IRequest<GetPostDetailViewModel>
    {
        public Guid PostId { get; set; }
    }
}
