using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commands.Create
{
    public class CreateBrandCommand : IRequest<CreateBrandResponse>
    {
        public string Name { get; set; }

        public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreateBrandResponse>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;
            // DI
            public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }

            public async Task<CreateBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
            {
                Brand brand = _mapper.Map<Brand>(request);
                await _brandRepository.AddAsync(brand);
                return new CreateBrandResponse() { Id = brand.Id, Name = brand.Name };
            }
        }
    }
}