﻿
namespace MovieTutorial.App.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("App.Genre")]
    [BasedOnRow(typeof(Entities.GenreRow))]
    public class GenreForm
    {
        public String Name { get; set; }
    }
}