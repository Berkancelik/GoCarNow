using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Queries.GetById
{
    public class GetByIdBrandQuery : IRequest<GetListResponse>
    {
        public Guid Id { get; set; }

        public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQuery, GetListResponse>
        {
            private readonly IMapper _mapper;
            private readonly IBrandRepository _brandRepository;

            public GetByIdBrandQueryHandler(IMapper mapper, IBrandRepository brandRepository)
            {
                _mapper = mapper;
                _brandRepository = brandRepository;
            }

            public async Task<GetListResponse> Handle(GetByIdBrandQuery request, CancellationToken cancellationToken)
            {
                Brand? brand = await _brandRepository.GetAsync(predicate: b => b.Id == request.Id, withDeleted: true, cancellationToken: cancellationToken);

                GetListResponse response = _mapper.Map<GetListResponse>(brand);

                return response;
            }


        }


    }
}