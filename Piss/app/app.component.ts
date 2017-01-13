import { Component } from '@angular/core';
import { ItemService } from './items/item.service';

@Component({
    selector: 'piss-app',
    template: `
        <div>
            <h1>Angular App - {{ pageTitle }}</h1>
            <piss-buckets></piss-buckets>
        </div>
        `,
    providers: [ItemService]
})
export class AppComponent {
    pageTitle: string = "PISS - Your buckets"
}