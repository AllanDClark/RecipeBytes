using MediatR;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Events.TagEvents.Commands;
using RecipeBytes.Infrastructure.Repositories;

namespace RecipeBytes.Events.TagEvents.CommandHandlers
{
    public class CreateTagHandler(TagRepository tagRepository) : IRequestHandler<CreateTag>
    {
        private readonly TagRepository _tagRepository = tagRepository;

        public async Task Handle(CreateTag request, CancellationToken cancellationToken)
        {
            var tag = new Tag
            {
                Name = request.Name,
                Description = request.Description
            };
            await _tagRepository.AddAsync(tag);
        }
    }
}
