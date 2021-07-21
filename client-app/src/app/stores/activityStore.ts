import { makeObservable, observable } from "mobx";

export default class ActivityStore {
    title = 'Helllo from mobx!!';

    contructor(){
        makeObservable(this, {
            title: observable
        })
    }
}