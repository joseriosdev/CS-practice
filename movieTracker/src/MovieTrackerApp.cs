using System;
using System.Collections.Generic;
using ConsoleTableExt;

namespace MovieTracker {
  public class MovieTrackerApp {
		public void Init() {
			RunApp();
		}

    private void RunApp() {
      var menuInput = "";

      do {
        PrintMenu();
        menuInput = Console.ReadLine();
        GetUserInput(menuInput);
      } while(menuInput != "5");
    }
    private void GetUserInput(string input){
      switch(input) {
        case "1":
          // RegisterMovie();
          break;
        case "2":
          PrintMovies();
          break;
        case "3":
          // SearchMovieByGenre();
          break;
        case "4":
          // SearchMovieByYear();
          break;
        case "5":
          ExitApp();
          break;
        default:
          AskAgain();
          break;
      }
    }
		private void PrintMenu() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			System.Console.WriteLine(@"
---- MENU ----
1. to register a movie
2. to print a movie
3. to search by genre
4. to search by year
5. exit
_________________________
			");
      Console.ResetColor();
		}
	
    // 1st Menu option
    private void RegisterMovie() {
      Console.ForegroundColor = ConsoleColor.Blue;

      System.Console.WriteLine("-- ADD MOVIE --\n* Movie Name:");
      var name = Console.ReadLine();
      System.Console.WriteLine("* Movie Description:");
      var description = Console.ReadLine();
      System.Console.WriteLine("* Movie Genre:");
      var genre = Console.ReadLine();
      System.Console.WriteLine("* Movie Year:");
      var yearInput = Console.ReadLine();

      int year = 0;

      while(!Int32.TryParse(yearInput, out year)) {
        Console.ForegroundColor = ConsoleColor.Red;

        System.Console.WriteLine("Please, enter a number");
        System.Console.WriteLine("* Movie Year:");
        yearInput = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Blue;
      }

      year = Int32.Parse(yearInput);

      var movieToAdd = new Movie(){Name = name, Description = description, Genre = genre, Year = year};
      var json = new JsonHandler();

      json.AddMovieToList(movieToAdd);

      Console.ResetColor();
    }

    // 2nd Menu option
    private void PrintMovies() {
      var json = new JsonHandler();
      var moviesJson = json.FetchMovies("moviesList.json");
      var movies = new List<Movie>(){};

      System.Console.WriteLine("============= MOVIES =============");

      foreach(var movie in moviesJson) {
        movies.Add(new Movie() {
          Name = movie.name, Description = movie.description, Genre = movie.genre, Year = movie.year
        });
        System.Console.WriteLine($"* Name: {movie.name} --- Description: {movie.description} --- Genre: {movie.genre} --- Year: {movie.year}\n");
      }
    }
    
    // 3rd Menu option
    private void SearchMovieByGenre() {
      Console.ForegroundColor = ConsoleColor.Green;

      System.Console.WriteLine(" Write the genre please:");
      var genreInput = Console.ReadLine();

      var json = new JsonHandler();
      var moviesList = json.FetchMovies("moviesList.json");
      var genreMatched = new List<Movie>(){};

      for(byte i = 0; i < moviesList.Length; i++) {
        if(moviesList[i].genre == genreInput) {
          genreMatched.Add(moviesList[i]);
          if(i == moviesList.Length - 1 && genreMatched.Count == 0) {
            
          }
        }
      }

      foreach(var movie in genreMatched) {

      }

      Console.ResetColor();
    }
    // 5th Menu option
    private void ExitApp() {
      Console.WriteLine("Exiting app...");
    }

    // Default Menu option
    private void AskAgain() {
      Console.ForegroundColor = ConsoleColor.Red;
      System.Console.WriteLine("Please, enter a number between 1 and 5");
      Console.ResetColor();
    }

  }
}