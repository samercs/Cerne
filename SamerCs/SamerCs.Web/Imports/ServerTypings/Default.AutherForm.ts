
namespace SamerCs.Default {
    export class AutherForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Auther';
    }

    export interface AutherForm {
        Name: Serenity.StringEditor;
    }

    [,
        ['Name', () => Serenity.StringEditor]
    ].forEach(x => Object.defineProperty(AutherForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}