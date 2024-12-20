// Movie section
List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}.");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\data\movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}


Console.WriteLine(); //Empty line for clarity
Console.WriteLine(new string('-', 30)); //Separator
Console.WriteLine(); //Another empty line for clarity


// Gift section
List<Gift> myGifts = new List<Gift>();
string[] giftsFromFile = GetDataFromFile();

foreach (string line in giftsFromFile)
{
    string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
    Gift newGift = new Gift(tempArray[0], tempArray[1]);
    myGifts.Add(newGift);
}

foreach (Gift giftFromList in myGifts)
{
    Console.WriteLine($"{giftFromList.Name} wants {giftFromList.Present} for Christmas.");
}

static string[] GetDataFromFile()
{
    string filePath = @"C:\data\frozen.txt";
    string[] dataFromFile = File.ReadAllLines(filePath);
    return dataFromFile;
}


// Movie class
class Movie
{
    string title; //Fields
    string year;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }
    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}


// Gift class
class Gift
{
    string name;
    string present;

    public Gift(string _name, string _present)
    {
        name = _name;
        present = _present;
    }

    public string Name
    {
        get { return name; }
    }

    public string Present
    {
        get { return present; }
    }
}