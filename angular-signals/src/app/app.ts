import { Component, computed, effect, signal } from '@angular/core';

@Component({
  selector: 'app-root',
  imports: [],
  template: `
    <h1>Current value of the counter {{counter()}}</h1>
    <h3>10x counter: {{derivedCounter()}}</h3>
    <button (click)="increment()">Increment</button>
    <button (click)="multiplier =10">Set multiplier to 10</button>

    <h3>Object Title: {{title()}}</h3>
    <button (click)="updateObject()">Update</button>
  `
})
export class App {

  multiplier = 0

  counter = signal(0)

  object = signal({
    id: 1,
    title: "Angular Rocks!"
  },
    {
      equal: (a, b) => a.id === b.id && a.title == b.title
    })

  title = computed(() => {
    console.log('Calling computed function...')
    const course = this.object();
    return course.title
  })

  updateObject() {
    this.object.set({
      id: 1,
      title: 'Angular Rocks! more'
    },
    )
  }

  derivedCounter = computed(() => {
    if (this.counter() == 0) return 0
    else return this.counter() * this.multiplier
  })

  constructor() {
    console.log(`counter value: ${this.counter()}`)
    effect(() => {
      const currentCounter = this.counter()
      const derivedCounter = this.derivedCounter()

      console.log(`current values: ${currentCounter} ${derivedCounter}`)
    })
  }

  increment() {
    console.log('updating counter...')
    this.counter.set(this.counter() + 1);
  }
}
