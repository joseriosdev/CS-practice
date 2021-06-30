using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace MovieTracker {
  class JsonHandler {
    public void AddMovieToList(Movie movie) {
      string jsonFile = "moviesList.json";
      var listOfMovies = FetchMovies(jsonFile);
      listOfMovies.Add(movie);
    }

    

    public List<Movie> FetchMovies(string fileName) {
      string jsonFile = File.ReadAllText(fileName);
      return JsonSerializer.Deserialize<List<Movie>>(jsonFile);
    }
  }
}