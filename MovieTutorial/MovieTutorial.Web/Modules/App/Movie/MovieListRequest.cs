using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTutorial.App
{
    using Serenity.Services;
    using System.Collections.Generic;

    public class MovieListRequest : ListRequest
    {
        public List<int> Genres { get; set; }
    }
}