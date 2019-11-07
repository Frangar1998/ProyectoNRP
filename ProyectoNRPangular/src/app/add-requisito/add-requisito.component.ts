import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-requisito',
  templateUrl: './add-requisito.component.html',
  styleUrls: ['./add-requisito.component.css']
})
export class AddRequisitoComponent implements OnInit {

  angForm: FormGroup;

  constructor(private fb: FormBuilder) { 
    this.createForm();
  }

  createForm() {
    this.angForm = this.fb.group({
      NombreRequisito: ['', Validators.required ],
      EsfuerzoRequisito: ['', Validators.required ]
    });
  }

  ngOnInit() {
  }

}
