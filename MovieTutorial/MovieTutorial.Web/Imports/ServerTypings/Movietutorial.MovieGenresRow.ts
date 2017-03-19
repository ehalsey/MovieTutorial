
namespace MovieTutorial.Movietutorial {
    export interface MovieGenresRow {
        MovieGenreId?: number;
        MovieId?: number;
        GenreId?: number;
        MovieTitle?: string;
        MovieDescription?: string;
        MovieStoryline?: string;
        MovieYear?: number;
        MovieReleaseDate?: string;
        MovieRuntime?: number;
        MovieKind?: number;
        MovieTestField?: string;
        GenreName?: string;
    }

    export namespace MovieGenresRow {
        export const idProperty = 'MovieGenreId';
        export const localTextPrefix = 'Movietutorial.MovieGenres';

        export namespace Fields {
            export declare const MovieGenreId;
            export declare const MovieId;
            export declare const GenreId;
            export declare const MovieTitle: string;
            export declare const MovieDescription: string;
            export declare const MovieStoryline: string;
            export declare const MovieYear: string;
            export declare const MovieReleaseDate: string;
            export declare const MovieRuntime: string;
            export declare const MovieKind: string;
            export declare const MovieTestField: string;
            export declare const GenreName: string;
        }

        ['MovieGenreId', 'MovieId', 'GenreId', 'MovieTitle', 'MovieDescription', 'MovieStoryline', 'MovieYear', 'MovieReleaseDate', 'MovieRuntime', 'MovieKind', 'MovieTestField', 'GenreName'].forEach(x => (<any>Fields)[x] = x);
    }
}

