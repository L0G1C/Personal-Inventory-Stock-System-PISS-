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

    constructor(private _itemService: ItemService) {
        
    }

    ngOnInit(): void {
        this.itemTypes = this._itemService.getItemTypes();
    }

}