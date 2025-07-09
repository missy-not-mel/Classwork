//Service manage the data for the app and access to the data

// Created via ng g service services/pet.service
// Which makes it Dependency Injectable automatically
//       and creates an empty constructor
import { Injectable } from '@angular/core';
import {PetInfo} from '../interfaces/pet-info'

@Injectable({
  providedIn: 'root'
})
// The class of the service (aka module) contains the data and the funtions to manage the data
export class PetService {

// Typically data is kept in an array inside the service 
// and is described by an interface
petData : PetInfo[] = [] // Hold the data for the service - initially empty 

 // Constructor is run when the service is started
 // Initialize any data (assign it, get it from file, database or API )
  constructor() { 
    this.petData.push({name:'Olive', type: 'Dog', gender: 'Female'})
    this.petData.push({name:'Kayla', type: 'Dog', gender: 'Female'})
    this.petData.push({name:'Jojo', type: 'Dog', gender: 'Male'})
    this.petData.push({name:'Sokka', type: 'Cat', gender: 'Male'})
  }


  // Provide a function to return the array of data
  getPetData() : PetInfo[] {
    return this.petData;
  }
  
}
