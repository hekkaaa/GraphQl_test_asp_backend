using GraphQlServer.Context;
using GraphQlServer.Repository.Entities;

namespace GraphQlServer.GraphQL
{
    public class Query
    {
        /// <summary>
        /// Get Bonds
        /// </summary>
        public IQueryable<Bond> GetBonds([ScopedService] ApplicationContext context)
        {
           return context.Bonds;
        }

        /// <summary>
        /// Get Movie
        /// </summary>
        public IQueryable<Movie> GetMovie([ScopedService] ApplicationContext context)
        {
            return context.Movies;
        }

        /// <summary>
        /// Get Director
        /// </summary>
        public IQueryable<Director> GetBDirector([ScopedService] ApplicationContext context)
        {
            return context.Directors;
        }

    }
}
