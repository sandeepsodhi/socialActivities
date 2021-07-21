import { makeAutoObservable } from "mobx";

export default class ActivityStore {
    title = 'Helllo from mobx!!';

    constructor(){
        makeAutoObservable(this)
    }

    setTitle = () => {
        this.title = this.title + '!';
    }
}