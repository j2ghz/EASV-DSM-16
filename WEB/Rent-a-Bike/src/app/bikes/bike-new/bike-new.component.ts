import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-bike-new',
  templateUrl: './bike-new.component.html',
  styleUrls: ['./bike-new.component.css']
})
export class BikeNewComponent implements OnInit {

  bikeForm: FormGroup;
  constructor(private fb: FormBuilder) {
    this.createForm();
  }

  ngOnInit() {
  }

  createForm() {
    this.bikeForm = this.fb.group({
      name: ['', Validators.required],
      notes: '',
      bikeModel: this.fb.group({
        modelName: '',
        modelSize: ''
      }),
      status: ''
    });
  }

}
