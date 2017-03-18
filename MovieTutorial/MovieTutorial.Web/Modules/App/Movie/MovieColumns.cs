
namespace MovieTutorial.App.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("App.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow))]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, HeaderCssClass("s-App-grid-alignRight")]
        public Int32 MovieId { get; set; }
        [EditLink]
        public String Title { get; set; }
        public String Description { get; set; }
        public String Storyline { get; set; }
        public Int32 Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Width(100), AlignRight, HeaderCssClass("s-App-grid-alignRight")]
        public Int32 Runtime { get; set; }
        public String TestField { get; set; }
        public MovieKind Kind { get; set; }
    }
}