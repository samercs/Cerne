
namespace SamerCs.Default {
    export interface AutherRow {
        Id?: number;
        Name?: string;
    }

    export namespace AutherRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Default.Auther';

        export namespace Fields {
            export declare const Id;
            export declare const Name;
        }

        [
            'Id',
            'Name'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}