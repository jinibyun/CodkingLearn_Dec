import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import { NavbarComponent } from './component/navbar/navbar.component';
import { LogFormComponent } from './component/log-form/log-form.component';
import { LogsComponent } from './component/logs/logs.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    LogFormComponent,
    LogsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
