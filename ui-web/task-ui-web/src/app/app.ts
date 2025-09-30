import { Component, inject, OnInit, signal, ViewChild } from '@angular/core';
import { MatSidenav, MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatTooltipModule } from '@angular/material/tooltip';
import { MatButtonModule } from '@angular/material/button';
import { CommonModule, DOCUMENT } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { RouterOutlet } from '@angular/router';

type toggleType = 'Light Mode' | 'Dark Mode' | 'Com Segurança' | 'Sem Segurança';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    MatSidenavModule,
    MatToolbarModule,
    MatTooltipModule,
    MatButtonModule,
    MatIconModule,
    MatListModule,
    RouterOutlet,
    CommonModule,
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
          <a
            mat-list-item
            (click)="toggle()"
            matTooltip="Mínimizar Espaço Aberto"
            matTooltipPosition="left"
            #tooltip="matTooltip"
            >{{ this.closeLb }}
            <i [ngClass]="isAngle ? 'pi pi-angle-double-left' : 'pi pi-angle-double-right'"> </i>
          </a>
          <a
            mat-list-item
            (click)="this.toggleSun()"
            matTooltip="Alterar Tema da Aplicação"
            matTooltipPosition="left"
          >
            {{ this.sunLb }}
            <i [ngClass]="isSun ? 'pi pi-sun' : 'pi pi-moon'"></i>
          </a>
          <a
            mat-list-item
            (click)="this.toggleLock()"
            matTooltip="Adicionar ou Remover Proteção"
            matTooltipPosition="left"
            >{{ this.lockLb }}<i [ngClass]="isLock ? 'pi pi-lock' : 'pi pi-lock-open'"></i>
          </a>
        </mat-nav-list>
      </mat-sidenav>
      <mat-sidenav-content>
        <mat-toolbar color="primary" class="mat-elevation-z4">
          <button mat-icon-button (click)="this.toggle()" class="hide-desktop">
            <mat-icon>{{ this.menuLb }}</mat-icon>
          </button>

          <span style="margin-left: 8px;">{{ this.layoutLb }}</span>
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

  private readonly document = inject(DOCUMENT);

  @ViewChild('drawer') drawer!: MatSidenav;

  protected readonly layoutLb = 'Layout UI Web Task Manager';

  protected readonly closeLb = 'Minímizar';

  protected readonly menuLb = 'menu';

  protected lockLb: toggleType = 'Com Segurança';

  protected sunLb: toggleType = 'Light Mode';

  protected isAngle = true;

  protected isLock = true;

  ngOnInit(): void {
    let theme = localStorage.getItem('theme') as string;

    if (theme) {
      this.initColorScheme(theme);
    }
  }

  toggle() {
    this.isAngle = !this.isAngle;

    this.drawer.toggle();
  }

  toggleSun() {
    let theme = localStorage.getItem('theme') as string;

    if (theme && theme === 'light') {
      this.initColorScheme('dark');
    } else {
      this.initColorScheme('light');
    }
  }

  private initColorScheme(arg: string) {
    this.document.body.style.colorScheme = arg;

    localStorage.setItem('theme', arg);

    this.sunLb = arg === 'light' ? 'Light Mode' : 'Dark Mode';
  }

  toggleLock() {
    this.lockLb = this.isLock ? 'Sem Segurança' : 'Com Segurança';

    this.isLock = !this.isLock;
  }

  protected get isSun() {
    return localStorage.getItem('theme') === 'light';
  }
}
