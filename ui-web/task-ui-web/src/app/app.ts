import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    MatSidenavModule,
    MatToolbarModule,
    MatButtonModule,
    MatIconModule,
    MatListModule,
    RouterOutlet,
  ],
  template: `
    <mat-sidenav-container style="height: 100vh;">
      <mat-sidenav
        #drawer
        mode="side"
        class="mat-elevation-z4"
        fixedInViewport="true"
        fixedTopGap="64"
      >
        <mat-nav-list>
          <a mat-list-item routerLink="/" (click)="drawer.toggle()">Home</a>
        </mat-nav-list>
      </mat-sidenav>
      <mat-sidenav-content>
        <mat-toolbar color="primary" class="mat-elevation-z4">
          <button mat-icon-button (click)="drawer.toggle()" class="hide-desktop">
            <mat-icon>menu</mat-icon>
          </button>
          <span style="margin-left: 8px;">Layout UI Web</span>
        </mat-toolbar>
        <div style="padding: 24px;">
          <router-outlet></router-outlet>
        </div>
      </mat-sidenav-content>
    </mat-sidenav-container>
  `,
})
export class App {
  protected readonly title = signal('task-ui-web');
}
