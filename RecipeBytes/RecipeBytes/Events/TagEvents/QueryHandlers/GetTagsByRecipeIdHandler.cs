using MediatR;
using RecipeBytes.Domain.Entities;
using RecipeBytes.Events.TagEvents.Queries;
using RecipeBytes.Infrastructure.Repositories;

namespace RecipeBytes.Events.TagEvents.QueryHandlers
{
    public class GetTagsByRecipeIdHandler(TagRepository tagRepository) : IRequestHandler<GetTagsByRecipeId, IEnumerable<Tag>>
    {
        private readonly TagRepository _tagRepository = tagRepository;

        public async Task<IEnumerable<Tag>> Handle(GetTagsByRecipeId request, CancellationToken cancellationToken)
        {
            return await _tagRepository.GetTagsByRecipeIdAsync(request.RecipeId);
        }
    }
}
