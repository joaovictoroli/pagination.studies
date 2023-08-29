import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { PageChangedEvent } from 'ngx-bootstrap/pagination';
import { PokemonService } from 'src/app/_services/pokemon.service';
import { Pokemon } from 'src/app/models/pokemon';

@Component({
  selector: 'app-pokemon-list',
  templateUrl: './pokemon-list.component.html',
  styleUrls: ['./pokemon-list.component.css'],
})
export class PokemonListComponent implements OnInit {
  typesArray: String[] = [
    'normal',
    'fire',
    'grass',
    'electric',
    'ice',
    'fighting',
    'poison',
    'ground',
    'flying',
    'psychic',
    'bug',
    'rock',
    'ghost',
    'dragon',
    'dark',
  ];
  pokemons: Pokemon[] | undefined;
  pageNumber = 1;
  pageSize = 10;
  totalItens = 151;
  @Input() nameFilterValue!: string;
  @Input() typeFilterValue!: string;
  check = 'noFilters';

  constructor(private pokemonService: PokemonService, private router: Router) {}

  ngOnInit(): void {
    this.loadPokemons();
  }

  // pokemon-list
  loadPokemons() {
    var response = this.pokemonService
      .getPokemons(this.pageNumber, this.pageSize)
      .subscribe({
        next: (response) => {
          if (response.result && response.pagination) {
            this.pokemons = response.result;
            this.totalItens = response.pagination.totalItems;
          }
        },
      });
  }

  pageChanged(event: PageChangedEvent) {
    console.log(this.check);
    if (this.pageNumber !== event.page) {
      this.pageNumber = event.page;
      if (this.check == 'noFilters') {
        this.loadPokemons();
      }
      if (this.check == 'nameFilter') {
        this.nameFilter(this.nameFilterValue);
      }
    }
  }

  open_detail(pokemonId: number) {
    this.router.navigate(['pokemon-detail', pokemonId]);
  }

  nameFilter(nameFilterValue: string) {
    this.pokemonService
      .nameFiltering(nameFilterValue, this.pageNumber, this.pageSize)
      .subscribe({
        next: (response) => {
          if (response.result && response.pagination) {
            this.pokemons = response.result;
            this.totalItens = response.pagination.totalItems;
          }
        },
      });

    this.check = 'nameFilter';
    console.log(this.check);
  }

  // end pokemon-list

  // pokemon-detail
}
