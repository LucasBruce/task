import { Component, signal, ViewChild } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { MatSidenav, MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
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
        position="start"
      >
        <mat-nav-list class="m-3">
          <a mat-list-item routerLink="/" (click)="toggle()">
            Mínimizar
            @if (this.isAngle) {
              <i class="pi pi-angle-double-right"></i>
            } @else {
              <i class="pi pi-angle-double-left"></i>
            }
          </a>
          <a mat-list-item routerLink="/" (click)="toggleSun()">
            @if (this.isSun) {
              {{ sunLabel }}
              <i class="pi pi-sun"></i>
            } @else {
              {{ sunLabel }}
              <i class="pi pi-moon"></i>
            }
          </a>
          <a mat-list-item routerLink="/" (click)="toggleLock()">
            Segurança
            @if (this.isLock) {
              <i class="pi pi-lock"></i>
            } @else {
              <i class="pi pi-lock-open"></i>
            }
          </a>
        </mat-nav-list>
      </mat-sidenav>
      <mat-sidenav-content>
        <mat-toolbar color="primary" class="mat-elevation-z4">
          <button mat-icon-button (click)="toggle()" class="hide-desktop">
            <mat-icon>menu</mat-icon>
          </button>

          <span style="margin-left: 8px;">Layout UI Web Task Manager</span>
        </mat-toolbar>
        <div style="padding: 24px;">
          <router-outlet></router-outlet>
        </div>
      </mat-sidenav-content>
    </mat-sidenav-container>
  `,
  styleUrl: './app.scss',
})
export class App {
  sunLabel = 'Light Mode';
  isAngle = true;
  isLock = true;
  isSun = true;

  protected readonly title = signal('task-ui-web');

  @ViewChild('drawer') drawer!: MatSidenav;

  toggle() {
    this.isAngle = !this.isAngle;

    this.drawer.toggle();
  }

  toggleSun() {
    this.isSun = !this.isSun;

    this.sunLabel = this.isSun ? 'Light Mode' : 'Dark Mode';
  }

  toggleLock() {
    this.isLock = !this.isLock;
  }
}
