namespace SamerCs.Default {
    export interface BookRow {
        Id?: number;
        Name?: string;
        NoP?: number;
        Type?: BookType;
    }

    export namespace BookRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Default.Book';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            NoP = "NoP",
            Type = "Type"
        }
    }
}

