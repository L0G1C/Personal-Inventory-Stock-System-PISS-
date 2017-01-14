import {PipeTransform, Pipe} from "@angular/core";
import { IItemType } from "./itemtype";

@Pipe({
    name: "itemTypeFilter"
})
export class ItemTypeFilterPipe implements PipeTransform {
    transform(value: IItemType[], filterBy: string): IItemType[] {
        //If filterBY text is given, bring it to lowercase
        filterBy = filterBy ? filterBy.toLocaleLowerCase() : null;
        // Return the array of itemtypes, filtered by the filterBy string
        return filterBy
            ? value.filter((itemtype: IItemType) =>
                itemtype.description.toLocaleLowerCase().indexOf(filterBy) !== -1)
            : value;
    }
}