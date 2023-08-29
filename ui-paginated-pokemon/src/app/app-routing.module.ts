import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PokemonDetailComponent } from './pokemon/pokemon-detail/pokemon-detail.component';
import { PokemonListComponent } from './pokemon/pokemon-list/pokemon-list.component';
import { NewPokemonListComponent } from './pokemon/new-pokemon-list/new-pokemon-list.component';

const routes: Routes = [
  { path: 'pokemons', component: PokemonListComponent },
  { path: 'n-pokemons', component: NewPokemonListComponent },
  { path: 'pokemon-detail/:pokemonId', component: PokemonDetailComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
