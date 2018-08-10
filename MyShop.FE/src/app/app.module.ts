import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { NbThemeModule, NbSidebarModule, NbLayoutModule, NbSidebarService } from '@nebular/theme';

import { AppComponent } from './app.component';
import { SideBarComponent } from './shared/layout/side-bar/side-bar.component';

@NgModule({
  declarations: [
    AppComponent,
    SideBarComponent
  ],
  imports: [
    BrowserModule,
    NbThemeModule.forRoot({ name: 'default' }),
    RouterModule.forRoot(
      [
        { path: "", component: SideBarComponent}
      ]
    ),
    NbLayoutModule,
    NbSidebarModule
  ],
  schemas: [ ],
  providers: [NbSidebarService],
  bootstrap: [AppComponent]
})
export class AppModule { }
