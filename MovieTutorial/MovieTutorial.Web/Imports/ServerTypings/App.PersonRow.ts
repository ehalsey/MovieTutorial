﻿namespace MovieTutorial.App {
    export interface PersonRow {
        PersonId?: number;
        Firstname?: string;
        Lastname?: string;
        BirthDate?: string;
        BirthPlace?: string;
        Gender?: Gender;
        Height?: number;
        Fullname?: string;
    }

    export namespace PersonRow {
        export const idProperty = 'PersonId';
        export const nameProperty = 'Fullname';
        export const localTextPrefix = 'App.Person';
        export const lookupKey = 'MovieDB.Person';

        export function getLookup(): Q.Lookup<PersonRow> {
            return Q.getLookup<PersonRow>('MovieDB.Person');
        }

        export namespace Fields {
            export declare const PersonId: string;
            export declare const Firstname: string;
            export declare const Lastname: string;
            export declare const BirthDate: string;
            export declare const BirthPlace: string;
            export declare const Gender: string;
            export declare const Height: string;
            export declare const Fullname: string;
        }

        ['PersonId', 'Firstname', 'Lastname', 'BirthDate', 'BirthPlace', 'Gender', 'Height', 'Fullname'].forEach(x => (<any>Fields)[x] = x);
    }
}

