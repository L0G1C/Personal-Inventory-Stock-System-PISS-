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
var core_1 = require("@angular/core");
var item_service_1 = require("./item.service");
//main item type component
var ItemTypeListComponent = (function () {
    function ItemTypeListComponent(_itemService) {
        this._itemService = _itemService;
    }
    ItemTypeListComponent.prototype.ngOnInit = function () {
        var _this = this;
        this._itemService.getItemTypes()
            .subscribe(function (itemtypesfromapi) { return _this.itemTypes = itemtypesfromapi; }, function (error) { return _this.errorMessage = error; });
    };
    ItemTypeListComponent = __decorate([
        core_1.Component({
            selector: "piss-buckets",
            moduleId: module.id,
            templateUrl: "itemtype-list.component.html",
            styleUrls: ["itemtype-list.component.css"]
        }), 
        __metadata('design:paramtypes', [item_service_1.ItemService])
    ], ItemTypeListComponent);
    return ItemTypeListComponent;
}());
exports.ItemTypeListComponent = ItemTypeListComponent;
//# sourceMappingURL=itemtype-list.component.js.map