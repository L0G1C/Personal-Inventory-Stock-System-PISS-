import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent }  from './app.component';
import { ItemTypeListComponent }  from './items/itemtype-list.component';

@NgModule({
  imports: [ BrowserModule ],
  declarations: [AppComponent,
      ItemTypeListComponent ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
