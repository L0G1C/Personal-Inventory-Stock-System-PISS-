import { Component } from '@angular/core';
import { IItemType } from './itemtype';

//main item type component
@Component({
    selector: 'piss-buckets',
    moduleId: module.id,
    templateUrl: 'itemtype-list.component.html',
    styleUrls: ['itemtype-list.component.css']
})
export class ItemTypeListComponent {
    listFilter: string;
    itemTypes: IItemType[] = [
        {
            "itemTypeId": 1,
            "description": "Books",
            "imageId": 2,
            "isActive": 1,
            "userId": "leo"
            
        },
        {
            "itemTypeId": 2,
            "description": "Video Games",
            "imageId": 2,
            "isActive": 1,
            "userId": "leo"
        }
    ];

}