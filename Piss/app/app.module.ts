import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule }  from "@angular/forms"
import { AppComponent }  from "./app.component";
import { ItemTypeListComponent }  from "./items/itemtype-list.component";
import { ItemTypeFilterPipe } from "./items/itemtype-filter";
import { HttpModule } from "@angular/http";

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule],
    declarations: [
        AppComponent,
        ItemTypeListComponent,
        ItemTypeFilterPipe],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
