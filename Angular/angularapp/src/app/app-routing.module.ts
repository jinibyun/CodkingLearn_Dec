import { NgModule } from '@angular/core';
import { RouterModule, Routes} from '@angular/router';
import { HomeComponent } from './testComponents/home/home.component';

// post and list components belows
import { SeventhExampleComponent } from './testComponents/seventhExample/seventhExample.component';
import { EigthExampleComponent } from './testComponents/eigthExample/eigthExample.component';
import { PostDetailComponent } from './testComponents/post-detail/post-detail.component';

import { NotFoundComponent } from './testComponents/not-found/not-found.component';


const routes : Routes = [
  { path : '', component:HomeComponent},
  { path : 'users', component:SeventhExampleComponent},
  { path : 'posts', component:EigthExampleComponent},
  { path : 'post/:id', component:PostDetailComponent},
  { path : '**', component: NotFoundComponent}
];

@NgModule({
  exports: [RouterModule],
  imports: [
    RouterModule.forRoot(routes)
  ]
})
export class AppRoutingModule { }
