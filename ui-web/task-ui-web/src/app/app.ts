import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule, MatIconRegistry } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { Component, inject, OnInit, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { DomSanitizer } from '@angular/platform-browser';

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
          <a mat-list-item routerLink="/" (click)="drawer.toggle()">Mínimizar</a>
          <a mat-list-item routerLink="/" (click)="drawer.toggle()">Temas</a>
          <a mat-list-item routerLink="/" (click)="drawer.toggle()">Iniciar Aplicação com Segurança</a>
          <a mat-list-item routerLink="/" (click)="drawer.toggle()">Iniciar Aplicação sem Segurança</a>
        </mat-nav-list>
      </mat-sidenav>
      <mat-sidenav-content>
        <mat-toolbar color="primary" class="mat-elevation-z4">
          <button mat-icon-button (click)="drawer.toggle()" class="hide-desktop">
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
export class App implements OnInit {
  protected readonly title = signal('task-ui-web');

  matIconRegistry = inject(MatIconRegistry);

  domSanitizer = inject(DomSanitizer);

  ngOnInit(): void {
    this.matIconRegistry.addSvgIcon(
      'home',
      this.domSanitizer.bypassSecurityTrustResourceUrl('assets/icons/home.svg')
    );
  
    this.matIconRegistry.addSvgIcon(
      'dark_mode',
      this.domSanitizer.bypassSecurityTrustResourceUrl('assets/icons/dark_mode.svg')
    );

    this.matIconRegistry.addSvgIcon(
      'light_mode',
      this.domSanitizer.bypassSecurityTrustResourceUrl('assets/icons/light_mode.svg')
    );

    this.matIconRegistry.addSvgIcon(
      'minimize',
      this.domSanitizer.bypassSecurityTrustResourceUrl('assets/icons/minimize.svg')
    );

    this.matIconRegistry.addSvgIcon(
      'encrypted_off',
      this.domSanitizer.bypassSecurityTrustResourceUrl('assets/icons/encrypted_off.svg')
    );

    this.matIconRegistry.addSvgIcon(
      'encrypted_on',
      this.domSanitizer.bypassSecurityTrustResourceUrl('assets/icons/encrypted_on.svg')
    );
  }
}
