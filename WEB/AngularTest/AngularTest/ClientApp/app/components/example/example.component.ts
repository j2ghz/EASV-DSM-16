import { Component } from '@angular/core';

@Component({
    selector: 'example',
    templateUrl: './example.component.html'
})
export class ExampleComponent {
    public currentCount = 0;

    public randomCounter() {
        this.currentCount = Math.random() * 1000;
    }
}
