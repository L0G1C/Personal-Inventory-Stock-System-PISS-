import { Injectable } from '@angular/core';
import { IItemType } from './itemtype';

@Injectable()
export class ItemService {

    getItemTypes(): IItemType[] {
        return [
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
}