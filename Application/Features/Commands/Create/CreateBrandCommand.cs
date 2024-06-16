using Application.Repositories;
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
            // DI
            public CreateBrandCommandHandler(IBrandRepository brandRepository)
            {
                _brandRepository = brandRepository;
            }

            public async Task<CreateBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
            {
                Brand brand = new()
                {
                    Name = request.Name
                };
                await _brandRepository.AddAsync(brand);
                return new CreateBrandResponse() { Id = brand.Id, Name = brand.Name };
            }
        }
    }
}