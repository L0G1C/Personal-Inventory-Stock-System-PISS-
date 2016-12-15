import { Component } from '@angular/core';

@Component({
    selector: 'piss-app',
    template: `
        <div>
            <h1>Angular App - {{ pageTitle }}</h1>
            <piss-buckets></piss-buckets>
        </div>
        `
})
export class AppComponent {
    pageTitle: string = "PISS - Create a Bucket"
}