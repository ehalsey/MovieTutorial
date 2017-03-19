namespace MovieTutorial.App {
    export interface GenreRow {
        GenreId?: number;
        Name?: string;
    }

    export namespace GenreRow {
        export const idProperty = 'GenreId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'App.Genre';
        export const lookupKey = 'MovieTutorial.App.Genre';

        export function getLookup(): Q.Lookup<GenreRow> {
            return Q.getLookup<GenreRow>('MovieTutorial.App.Genre');
        }

        export namespace Fields {
            export declare const GenreId: string;
            export declare const Name: string;
        }

        ['GenreId', 'Name'].forEach(x => (<any>Fields)[x] = x);
    }
}

