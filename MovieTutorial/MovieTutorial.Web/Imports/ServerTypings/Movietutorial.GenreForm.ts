

namespace MovieTutorial.Movietutorial {
    export class GenreForm extends Serenity.PrefixedContext {
        static formKey = 'Movietutorial.Genre';
    }

    export interface GenreForm {
        Name: Serenity.StringEditor;
    }

    [['Name', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(GenreForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}