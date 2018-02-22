
namespace SamerCs.Default {

    @Serenity.Decorators.registerClass()
    export class AutherDialog extends Serenity.EntityDialog<AutherRow, any> {
        protected getFormKey() { return AutherForm.formKey; }
        protected getIdProperty() { return AutherRow.idProperty; }
        protected getLocalTextPrefix() { return AutherRow.localTextPrefix; }
        protected getNameProperty() { return AutherRow.nameProperty; }
        protected getService() { return AutherService.baseUrl; }

        protected form = new AutherForm(this.idPrefix);

    }
}