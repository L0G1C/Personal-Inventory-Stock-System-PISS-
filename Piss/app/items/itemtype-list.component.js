"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
//main item type component
var ItemTypeListComponent = (function () {
    function ItemTypeListComponent() {
        this.itemTypes = [
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
    ItemTypeListComponent = __decorate([
        core_1.Component({
            selector: 'piss-buckets',
            templateUrl: 'app/items/itemtype-list.component.html'
        }), 
        __metadata('design:paramtypes', [])
    ], ItemTypeListComponent);
    return ItemTypeListComponent;
}());
exports.ItemTypeListComponent = ItemTypeListComponent;
//# sourceMappingURL=itemtype-list.component.js.map