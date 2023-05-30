using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieApplication.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Rated = table.Column<string>(type: "TEXT", nullable: false),
                    Released = table.Column<string>(type: "TEXT", nullable: false),
                    Runtime = table.Column<string>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: false),
                    Director = table.Column<string>(type: "TEXT", nullable: false),
                    Writer = table.Column<string>(type: "TEXT", nullable: false),
                    Actors = table.Column<string>(type: "TEXT", nullable: false),
                    Plot = table.Column<string>(type: "TEXT", nullable: false),
                    Language = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    Awards = table.Column<string>(type: "TEXT", nullable: false),
                    Poster = table.Column<string>(type: "TEXT", nullable: false),
                    Metascore = table.Column<int>(type: "INTEGER", nullable: false),
                    imdbRating = table.Column<double>(type: "REAL", nullable: false),
                    imdbVotes = table.Column<string>(type: "TEXT", nullable: false),
                    imdbID = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    DVD = table.Column<string>(type: "TEXT", nullable: false),
                    BoxOffice = table.Column<string>(type: "TEXT", nullable: false),
                    Production = table.Column<string>(type: "TEXT", nullable: false),
                    Response = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Awards", "BoxOffice", "Country", "DVD", "Director", "Genre", "Language", "Metascore", "Plot", "Poster", "Production", "Rated", "Released", "Response", "Runtime", "Title", "Type", "Writer", "Year", "imdbID", "imdbRating", "imdbVotes" },
                values: new object[,]
                {
                    { 1, "Mark Kermode, Peter Jackson", "Nominated for 1 BAFTA Film Award. Another 4 wins & 10 nominations.", "N/A", "UK, New Zealand", "N/A", "Peter Jackson", "Documentary, History, War", "English", 91, "A documentary about World War I with never-before-seen footage to commemorate the centennial of the end of the war.", "https://m.media-amazon.com/images/M/MV5BZWI3ZThmYzUtNDJhOC00ZWY4LThiNmMtZDgxNjE3Yzk4NDU1XkEyXkFqcGdeQXVyNTk5Nzg1NjQ@._V1_SX300.jpg", "Warner Bros. Pictures", "R", "01 Feb 2019", "True", "99 min", "They Shall Not Grow Old", "movie", "Peter Jackson", 2018, "tt7905466", 8.3000000000000007, "21,722" },
                    { 2, "Fer Ochoa, Josue Ochoa, Juan Ochoa", "24 wins & 20 nominations.", "N/A", "Mexico", "N/A", "Luke Lorentzen", "Documentary, Action, Crime, Drama", "Spanish", 84, "In Mexico City's wealthiest neighborhoods, the Ochoa family runs a private ambulance, competing with other for-profit EMTs for patients in need of urgent help.", "https://m.media-amazon.com/images/M/MV5BMGYyZTk5MjYtNGY2ZS00NzRhLTgwMWMtZjhmMmQ4OGFkNTNiXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_SX300.jpg", "1091", "N/A", "06 Dec 2019", "True", "81 min", "Midnight Family", "movie", "Luke Lorentzen", 2019, "tt6010976", 7.7000000000000002, "330" },
                    { 3, "Mark Wahlberg, Dwayne Johnson, Anthony Mackie, Tony Shalhoub", "4 nominations.", "$49,300,000", "USA", "27 Aug 2013", "Michael Bay", "Action, Comedy, Crime, Drama", "English", 45, "A trio of bodybuilders in Florida get caught up in an extortion ring and a kidnapping scheme that goes terribly wrong.", "https://m.media-amazon.com/images/M/MV5BMTU0NDE5NTU0OV5BMl5BanBnXkFtZTcwMzI1OTMzOQ@@._V1_SX300.jpg", "Paramount Studios", "R", "26 Apr 2013", "True", "129 min", "Pain & Gain", "movie", "Christopher Markus (screenplay), Stephen McFeely (screenplay), Pete Collins (based on the magazine articles by)", 2013, "tt1980209", 6.4000000000000004, "191,388" },
                    { 4, "Robert De Niro, Al Pacino, Joe Pesci, Harvey Keitel", "Nominated for 5 Golden Globes. Another 35 wins & 159 nominations.", "N/A", "USA", "27 Nov 2019", "Martin Scorsese", "Biography, Crime, Drama", "English, Italian, Latin, Spanish", 94, "A mob hitman recalls his possible involvement with the slaying of Jimmy Hoffa.", "https://m.media-amazon.com/images/M/MV5BMGUyM2ZiZmUtMWY0OC00NTQ4LThkOGUtNjY2NjkzMDJiMWMwXkEyXkFqcGdeQXVyMzY0MTE3NzU@._V1_SX300.jpg", "Netflix", "R", "27 Nov 2019", "True", "209 min", "The Irishman", "movie", "Steven Zaillian (screenplay), Charles Brandt (book)", 2019, "tt1302006", 8.1999999999999993, "144,536" },
                    { 5, "Leonardo DiCaprio, Brad Pitt, Margot Robbie, Emile Hirsch", "Won 3 Golden Globes. Another 70 wins & 242 nominations.", "N/A", "USA, UK, China", "22 Nov 2019", "Quentin Tarantino", "Comedy, Drama", "English, Italian, Spanish", 83, "A faded television actor and his stunt double strive to achieve fame and success in the film industry during the final years of Hollywood's Golden Age in 1969 Los Angeles.", "https://m.media-amazon.com/images/M/MV5BOTg4ZTNkZmUtMzNlZi00YmFjLTk1MmUtNWQwNTM0YjcyNTNkXkEyXkFqcGdeQXVyNjg2NjQwMDQ@._V1_SX300.jpg", "Columbia Pictures", "R", "26 Jul 2019", "True", "161 min", "Once Upon a Time... in Hollywood", "movie", "Quentin Tarantino", 2019, "tt7131622", 7.7999999999999998, "318,841" },
                    { 6, "Adam Driver, Scarlett Johansson, Julia Greer, Azhy Robertson", "Won 1 Golden Globe. Another 86 wins & 212 nominations.", "N/A", "UK, USA", "06 Dec 2019", "Noah Baumbach", "Comedy, Drama, Romance", "English", 93, "Noah Baumbach's incisive and compassionate look at a marriage breaking up and a family staying together.", "https://m.media-amazon.com/images/M/MV5BZGVmY2RjNDgtMTc3Yy00YmY0LTgwODItYzBjNWJhNTRlYjdkXkEyXkFqcGdeQXVyMjM4NTM5NDY@._V1_SX300.jpg", "Netflix", "R", "06 Dec 2019", "True", "137 min", "Marriage Story", "movie", "Noah Baumbach", 2019, "tt7653254", 8.0999999999999996, "108,524" },
                    { 7, "Winona Ryder, Gabriel Byrne, Trini Alvarado, Samantha Mathis", "Nominated for 3 Oscars. Another 5 wins & 15 nominations.", "N/A", "USA, Canada", "26 Feb 2008", "Gillian Armstrong", "Drama, Family, Romance", "English, German, French", 87, "The March sisters live and grow in post-Civil War America.", "https://m.media-amazon.com/images/M/MV5BNmJhNTgzMWYtZTU5OC00MmE2LTlkN2UtNWE0MmJiNWJmNmZjXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg", "N/A", "PG", "25 Dec 1994", "True", "115 min", "Little Women", "movie", "Louisa May Alcott (novel), Robin Swicord (screenplay)", 1994, "tt0110367", 7.2999999999999998, "45,297" },
                    { 8, "Kang-ho Song, Sun-kyun Lee, Yeo-jeong Jo, Woo-sik Choi", "Won 1 Golden Globe. Another 119 wins & 179 nominations.", "N/A", "South Korea", "14 Jan 2020", "Bong Joon Ho", "Comedy, Drama, Thriller", "Korean, English", 96, "All unemployed, Ki-taek and his family take peculiar interest in the wealthy and glamorous Parks, as they ingratiate themselves into their lives and get entangled in an unexpected incident.", "https://m.media-amazon.com/images/M/MV5BYWZjMjk3ZTItODQ2ZC00NTY5LWE0ZDYtZTI3MjcwN2Q5NTVkXkEyXkFqcGdeQXVyODk4OTc3MTY@._V1_SX300.jpg", "NEON", "R", "08 Nov 2019", "True", "132 min", "Parasite", "movie", "Bong Joon Ho (story), Bong Joon Ho (screenplay), Bong Joon Ho (story by), Jin Won Han (screenplay)", 2019, "tt6751668", 8.5999999999999996, "128,604" },
                    { 9, "Daniel Craig, Chris Evans, Ana de Armas, Jamie Lee Curtis", "Nominated for 3 Golden Globes. Another 22 wins & 37 nominations.", "N/A", "USA", "N/A", "Rian Johnson", "Comedy, Crime, Drama, Mystery, Thriller", "English, Spanish", 82, "A detective investigates the death of a patriarch of an eccentric, combative family.", "https://m.media-amazon.com/images/M/MV5BMGUwZjliMTAtNzAxZi00MWNiLWE2NzgtZGUxMGQxZjhhNDRiXkEyXkFqcGdeQXVyNjU1NzU3MzE@._V1_SX300.jpg", "Lionsgate", "PG-13", "27 Nov 2019", "True", "130 min", "Knives Out", "movie", "Rian Johnson", 2019, "tt8946378", 8.0999999999999996, "66,522" },
                    { 10, "Eddie Murphy, Keegan-Michael Key, Mike Epps, Craig Robinson", "Nominated for 2 Golden Globes. Another 17 wins & 54 nominations.", "N/A", "USA", "25 Oct 2019", "Craig Brewer", "Biography, Comedy, Drama", "English", 76, "Eddie Murphy portrays real-life legend Rudy Ray Moore, a comedy and rap pioneer who proved naysayers wrong when his hilarious, obscene, kung-fu fighting alter ego, Dolemite, became a 1970s Blaxploitation phenomenon.", "https://m.media-amazon.com/images/M/MV5BMzFiYWQxYzgtOThmYi00ZmIwLWFlZWMtMzk2NTI2YTYzMjkyXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_SX300.jpg", "Netflix", "R", "25 Oct 2019", "True", "118 min", "Dolemite Is My Name", "movie", "Scott Alexander, Larry Karaszewski", 2019, "tt8526872", 7.2999999999999998, "31,613" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
