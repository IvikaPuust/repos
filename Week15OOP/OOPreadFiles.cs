List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    //Console.WriteLine("Temp array");
    Movie newMovie = new Movie(tempArray[0], tempArray[2], tempArray[1]);
    myMovies.Add(newMovie);
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}. Rating: {movie.Rating}");
}
static string[] GetDataFromMyFile()
{
    string filePath = @"C:\data\movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }

}
class Movie
{
    string title; //fields
    string year;
    string rating;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }

    public string Rating
    {
        get { return rating; }
    }

    public Movie(string _title, string _year, string _rating)
    {
        this.title = _title; 
        this.year = _year;
        this.rating = _rating;
    }
}