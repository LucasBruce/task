import { PATHS } from './shared/constants/paths';
import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: PATHS.PAGES.LAYOUT,
    loadComponent: () => import('./pages/layout/layout').then((m) => m.Layout),
  },
];
