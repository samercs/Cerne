
namespace SamerCs.Default {

    @Serenity.Decorators.registerClass()
    export class BookDialog extends Serenity.EntityDialog<BookRow, any> {
        protected getFormKey() { return BookForm.formKey; }
        protected getIdProperty() { return BookRow.idProperty; }
        protected getLocalTextPrefix() { return BookRow.localTextPrefix; }
        protected getNameProperty() { return BookRow.nameProperty; }
        protected getService() { return BookService.baseUrl; }

        protected form = new BookForm(this.idPrefix);

    }
}