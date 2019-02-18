import { Component, OnInit, ChangeDetectorRef } from '@angular/core';


(<any>window).register = (cb) => {
  (<any>window).myCallBack = cb;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'MyTestApp';

  constructor(private chRef: ChangeDetectorRef){
    
  }
  

  ngOnInit() {
    (<any>window).register((newTitle) => {
      this.title = newTitle;
      this.chRef.detectChanges(); //Whenever you need to force update view
    })
  }

  ChangeTitle() {
    (<any>window).myCallBack("amitai");
  }

  sendArg() {
    (<any>window).external.notify("amitai1111");
  }

}
