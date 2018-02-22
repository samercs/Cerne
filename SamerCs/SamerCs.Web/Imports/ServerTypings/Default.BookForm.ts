namespace SamerCs.Default {
    export interface BookForm {
        Name: Serenity.StringEditor;
        NoP: Serenity.IntegerEditor;
        Type: Serenity.EnumEditor;
    }

    export class BookForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Book';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BookForm.init)  {
                BookForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.EnumEditor;

                Q.initFormType(BookForm, [
                    'Name', w0,
                    'NoP', w1,
                    'Type', w2
                ]);
            }
        }
    }
}

