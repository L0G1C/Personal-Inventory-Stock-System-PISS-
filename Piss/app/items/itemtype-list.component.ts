import { Component } from '@angular/core';

@Component({
    selector: 'piss-buckets',
    templateUrl: 'app/items/itemtype-list.component.html'
})
export class ItemTypeListComponent {

    itemTypes: any[] = [
        {
            "ItemTypeId"    : 1
        }
    ];

}