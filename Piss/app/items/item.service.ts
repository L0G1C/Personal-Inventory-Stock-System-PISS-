import { Injectable } from "@angular/core";
import { IItemType } from "./itemtype";
import { Http, Response } from "@angular/http";
import { Observable } from "rxjs/Observable";
import "rxjs/add/operator/map";
import "rxjs/add/operator/do";
import "rxjs/add/operator/catch";

@Injectable()
export class ItemService {

    private _url = "/api/ItemType";

    constructor(private _http: Http){}

    getItemTypes(): Observable<IItemType[]> {
        return (this._http.get(this._url)
            .map((response: Response) => <IItemType[]> response.json())
            .do(data => console.log("all: " + JSON.stringify(data)))
            .catch(this.handleError)) as any;

    }


    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || "Error on API call");
    }
}