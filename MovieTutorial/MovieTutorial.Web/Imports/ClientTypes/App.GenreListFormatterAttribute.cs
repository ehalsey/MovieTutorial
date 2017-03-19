using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace MovieTutorial.App
{
    public partial class GenreListFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "MovieTutorial.App.GenreListFormatter";

        public GenreListFormatterAttribute()
            : base(Key)
        {
        }
    }
}

