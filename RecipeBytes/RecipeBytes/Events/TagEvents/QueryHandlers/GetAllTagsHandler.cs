using MediatR;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Events.TagEvents.Queries;
using RecipeBytes.Infrastructure.Repositories;

namespace RecipeBytes.Events.TagEvents.QueryHandlers
{
    public class GetAllTagsHandler(TagRepository tagRepository) : IRequestHandler<GetAllTags, IEnumerable<Tag>>
    {
        private readonly TagRepository _tagRepository = tagRepository;

        public async Task<IEnumerable<Tag>> Handle(GetAllTags request, CancellationToken cancellationToken)
        {
            return await _tagRepository.GetAllAsync();
        }

    }
}
