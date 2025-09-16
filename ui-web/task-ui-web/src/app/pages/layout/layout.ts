import { Component } from '@angular/core';
import { MatSidenavModule } from '@angular/material/sidenav';

@Component({
  selector: 'app-layout',
  standalone: true,
  imports: [MatSidenavModule],
  template: `
    <mat-sidenav-container>
      <mat-sidenav mode="side" opened>
        <p>{{ titulo }}</p>
      </mat-sidenav>
      <mat-sidenav-content>
        <p>Main content goes here</p>
      </mat-sidenav-content>
    </mat-sidenav-container>
  `,
})
export class Layout {

  get titulo(){
    return 'Toggle me!';
  }
}
