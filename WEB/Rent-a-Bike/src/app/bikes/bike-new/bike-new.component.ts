import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-bike-new',
  templateUrl: './bike-new.component.html',
  styleUrls: ['./bike-new.component.css']
})
export class BikeNewComponent implements OnInit {

  bikeFrom: FormGroup;
  constructor(private fb: FormBuilder) {
    this.createForm();
  }

  ngOnInit() {
  }

  createForm() {
    this.bikeFrom = this.fb.group({
      name: '', // <--- the FormControl called "name"
    });
  }

}
