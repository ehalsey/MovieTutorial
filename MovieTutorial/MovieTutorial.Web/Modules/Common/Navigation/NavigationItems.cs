using Serenity.Navigation;
using Administration = MovieTutorial.Administration.Pages;
//http://simplelineicons.com/
[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "icon-speedometer")]

[assembly: NavigationMenu(2000, "Movie Database", icon: "icon-film")]
[assembly: NavigationLink(2100, "Movie Database/Movies", typeof(MovieTutorial.App.Pages.MovieController), icon: "icon-camrecorder")]
[assembly: NavigationLink(2100, "Movie Database/Genres", typeof(MovieTutorial.App.Pages.GenreController), icon: "icon-pin")]
[assembly: NavigationLink(2100, "Movie Database/People", typeof(MovieTutorial.App.Pages.PersonController), icon: "icon-people")]

