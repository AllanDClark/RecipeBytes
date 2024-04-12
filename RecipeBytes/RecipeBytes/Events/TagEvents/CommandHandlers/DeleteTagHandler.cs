using MediatR;
using RecipeBytes.Events.TagEvents.Commands;
using RecipeBytes.Infrastructure.Repositories;

namespace RecipeBytes.Events.TagEvents.CommandHandlers
{
    public class DeleteTagHandler(TagRepository tagRepository) : IRequestHandler<DeleteTag>
    {
        private readonly TagRepository _tagRepository = tagRepository;

        public async Task Handle(DeleteTag request, CancellationToken cancellationToken)
        {
            await _tagRepository.RemoveAsync(request.TagId);
        }
    }
}
