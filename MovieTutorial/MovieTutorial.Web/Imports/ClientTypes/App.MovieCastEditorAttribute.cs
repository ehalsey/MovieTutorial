using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace MovieTutorial.App
{
    public partial class MovieCastEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "MovieTutorial.App.MovieCastEditor";

        public MovieCastEditorAttribute()
            : base(Key)
        {
        }
    }
}

