import { Component } from '@angular/core';

//main item type component
@Component({
    selector: 'piss-buckets',
    templateUrl: 'app/items/itemtype-list.component.html'
})
export class ItemTypeListComponent {

    itemTypes: any[] = [
        {
            "ItemTypeId": 1,
            "Description": "Books",
            "ImageId": 2,
            "IsActive": 1,
            "UserId": "leo"
        },
        {
            "ItemTypeId": 2,
            "Description": "Video Games",
            "ImageId": 2,
            "IsActive": 1,
            "UserId": "leo"
        }
    ];

}