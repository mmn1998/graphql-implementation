using graphql.Models;
using HotChocolate;
using HotChocolate.Data;
using System.Collections.Generic;
using System.Linq;

namespace graphql.Data.GraphQL;

public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) =>
            context.Superheroes;
}
