using Movies.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movies.Client.ApiServices
{
    public class MovieApiService : IMovieApiService
    {
        public Task<Movie> CreateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public Task<Movie> DeleteMovie(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Movie> GetMovie(string id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movieList = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Genre = $"Sample Genre 1",
                    Owner = $"Sample owner 1",
                    ReleaseDate = new System.DateTime(2020, 1, 1)
                },

                new Movie
                {
                    Id = 2,
                    Genre = $"Sample Genre 2",
                    Owner = $"Sample owner 2",
                    ReleaseDate = new System.DateTime(2020, 1, 2)
                },

                new Movie
                {
                    Id = 3,
                    Genre = $"Sample Genre 3",
                    Owner = $"Sample owner 3",
                    ReleaseDate = new System.DateTime(2020, 1, 3)
                },

                new Movie
                {
                    Id = 4,
                    Genre = $"Sample Genre 4",
                    Owner = $"Sample owner 4",
                    ReleaseDate = new System.DateTime(2020, 1, 4)
                },

                new Movie
                {
                    Id = 5,
                    Genre = $"Sample Genre 5",
                    Owner = $"Sample owner 5",
                    ReleaseDate = new System.DateTime(2020, 1, 5)
                }
            };

            return await Task.FromResult(movieList);
        }

        public Task<Movie> UpdateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }
    }
}
