
namespace SamerCs.Default {

    @Serenity.Decorators.registerClass()
    export class BookGrid extends Serenity.EntityGrid<BookRow, any> {
        protected getColumnsKey() { return 'Default.Book'; }
        protected getDialogType() { return BookDialog; }
        protected getIdProperty() { return BookRow.idProperty; }
        protected getLocalTextPrefix() { return BookRow.localTextPrefix; }
        protected getService() { return BookService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}