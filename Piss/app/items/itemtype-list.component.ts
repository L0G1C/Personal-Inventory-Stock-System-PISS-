import { Component } from "@angular/core";
import { IItemType } from "./itemtype";
import { ItemService } from "./item.service";

//main item type component
@Component({
    selector: "piss-buckets",
    moduleId: module.id,
    templateUrl: "itemtype-list.component.html",
    styleUrls: ["itemtype-list.component.css"]
})
export class ItemTypeListComponent {
    listFilter: string;    
    itemTypes: IItemType[];
    errorMessage: string;

    constructor(private _itemService: ItemService) {
        
    }

    ngOnInit(): void {
        this._itemService.getItemTypes()
            .subscribe(
                itemtypesfromapi => this.itemTypes = itemtypesfromapi,
                error => this.errorMessage = <any>error);
        
    }

}