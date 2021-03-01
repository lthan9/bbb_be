﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Song;
using Application.Interfaces.Repo;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Song.Queries
{
    public class GetAllQuery : IRequest<PagedResponse<IEnumerable<SongDTO>>>
    {
        public PagedSortRequest _pagedSortRequest { get; set; }
    }
    public class GetAllHandler : IRequestHandler<GetAllQuery, PagedResponse<IEnumerable<SongDTO>>>
    {
        private readonly ISongRepository _songRepository;
        public GetAllHandler(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }
        public async Task<PagedResponse<IEnumerable<SongDTO>>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            var res = await _songRepository.GetAllPagedSortAsync(request._pagedSortRequest);
            var data = res.Select(s => _songRepository.MapSong(s)).ToList();
            return new PagedResponse<IEnumerable<SongDTO>> {
                Code = 200,
                Msg = "Get Song Ok",
                PageSize = request._pagedSortRequest.PageSize,
                Index = request._pagedSortRequest.Index  ,
                Data = data
            };
        }
    }
}
