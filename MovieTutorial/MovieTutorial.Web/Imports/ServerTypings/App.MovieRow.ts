namespace MovieTutorial.App {
    export interface MovieRow {
        MovieId?: number;
        Title?: string;
        Description?: string;
        Storyline?: string;
        Year?: number;
        ReleaseDate?: string;
        Runtime?: number;
    }

    export namespace MovieRow {
        export const idProperty = 'MovieId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'App.Movie';

        export namespace Fields {
            export declare const MovieId: string;
            export declare const Title: string;
            export declare const Description: string;
            export declare const Storyline: string;
            export declare const Year: string;
            export declare const ReleaseDate: string;
            export declare const Runtime: string;
        }

        ['MovieId', 'Title', 'Description', 'Storyline', 'Year', 'ReleaseDate', 'Runtime'].forEach(x => (<any>Fields)[x] = x);
    }
}

