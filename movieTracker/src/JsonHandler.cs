using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace MovieTracker {
  class JsonHandler {
    public void AddMovieToList(Movie movie) {
      string jsonFile = "moviesList.json";
      var listOfMovies = FetchMovies(jsonFile);
      listOfMovies.Add(movie);
    }

    

    public dynamic FetchMovies(string fileName) {
      return JsonConvert.DeserializeObject(File.ReadAllText(fileName));
    }
  }
}