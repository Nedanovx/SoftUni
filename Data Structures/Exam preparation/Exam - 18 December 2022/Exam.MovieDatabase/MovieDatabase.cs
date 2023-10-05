using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam.MovieDatabase
{
    public class MovieDatabase : IMovieDatabase
    {
        private List<Movie> movies;
        private List<Actor> actors;

        public MovieDatabase()
        {
            this.movies = new List<Movie>();
            this.actors = new List<Actor>();
        }
        public void AddActor(Actor actor)
        {
            actors.Add(actor);
        }

        public void AddMovie(Actor actor, Movie movie)
        {
            if(!actors.Contains(actor))
            {
                throw new ArgumentException();
            }
            movies.Add(movie);
            var currentActor = actors.FirstOrDefault(x => x.Id == actor.Id);
            currentActor.Movies.Add(movie);
        }

        public bool Contains(Actor actor)
        {
            return actors.Any(x => x.Id == actor.Id);
        }

        public bool Contains(Movie movie)
        {
            return movies.Any(x => x.Id == movie.Id);
        }

        public IEnumerable<Actor> GetActorsOrderedByMaxMovieBudgetThenByMoviesCount()
        {
            return actors.OrderByDescending(x => x.Movies.Max(x => x.Budget)).ThenByDescending(x => x.Movies.Count);
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return movies;
        }

        public IEnumerable<Movie> GetMoviesInRangeOfBudget(double lower, double upper)
        {
            return movies.Where(x => x.Budget >= lower && x.Budget <= upper).OrderByDescending(x => x.Rating);
        }

        public IEnumerable<Movie> GetMoviesOrderedByBudgetThenByRating()
        {
            return movies.OrderByDescending(x => x.Budget).ThenByDescending(x => x.Rating);
        }

        public IEnumerable<Actor> GetNewbieActors()
        {
            return actors.Where(x => x.Movies.Count == 0);
        }
    }
}
