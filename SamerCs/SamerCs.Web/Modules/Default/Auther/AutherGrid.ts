
namespace SamerCs.Default {

    @Serenity.Decorators.registerClass()
    export class AutherGrid extends Serenity.EntityGrid<AutherRow, any> {
        protected getColumnsKey() { return 'Default.Auther'; }
        protected getDialogType() { return AutherDialog; }
        protected getIdProperty() { return AutherRow.idProperty; }
        protected getLocalTextPrefix() { return AutherRow.localTextPrefix; }
        protected getService() { return AutherService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}