import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { PageChangedEvent } from 'ngx-bootstrap/pagination';
import { PokemonService } from 'src/app/_services/pokemon.service';
import { Pokemon } from 'src/app/models/pokemon';
import { QueryParams } from 'src/app/models/queryParams';

@Component({
  selector: 'app-new-pokemon-list',
  templateUrl: './new-pokemon-list.component.html',
  styleUrls: ['./new-pokemon-list.component.css'],
})
export class NewPokemonListComponent implements OnInit {
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
  @Input() nameFilterValue: string = '';
  @Input() typeFilterValue: string = '';
  pokemons: Pokemon[] | undefined;
  pageNumber = 1;
  pageSize = 10;
  totalItens = 151;

  constructor(private pokemonService: PokemonService, private router: Router) {}

  ngOnInit(): void {
    this.loadPokemons();
  }

  pageChanged(event: PageChangedEvent) {
    if (this.pageNumber !== event.page) {
      this.pageNumber = event.page;
      this.loadPokemons();
    }
  }

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

  open_detail(pokemonId: number) {
    this.router.navigate(['pokemon-detail', pokemonId]);
  }
  filtering(nameFilterValue: string, typeFilterValue: string) {
    let queryParams: QueryParams = {
      ItemsInPage: 10,
      PageNumber: this.pageNumber,
      nameFilter: nameFilterValue,
      typeFilter: typeFilterValue,
    };

    console.log('aqui');
    this.pokemonService.getPokemonsAllInOne(queryParams).subscribe({
      next: (response) => {
        console.log('aqui');
        if (response.result && response.pagination) {
          this.pokemons = response.result;
          this.totalItens = response.pagination.totalItems;
        }
      },
    });

    console.log(this.pokemons);
  }

  // open_detail(pokemonId: number) {
  //   this.router.navigate(['pokemon-detail', pokemonId]);
  // }
  // filtering(
  //   nameFilterValue: string | undefined,
  //   typeFilterValue: string | undefined
  // ) {
  //   console.log(nameFilterValue);
  //   console.log(typeof nameFilterValue);
  //   switch (true) {
  //     case typeof nameFilterValue == 'undefined' &&
  //       typeof typeFilterValue == 'undefined': {
  //       //both valid
  //       console.log('teste1');
  //       break;
  //     }
  //     case typeof nameFilterValue == 'undefined' &&
  //       typeof typeFilterValue != 'undefined': {
  //       // valid false
  //       console.log('teste2');
  //       break;
  //     }
  //     case typeof nameFilterValue != 'undefined' &&
  //       typeof typeFilterValue == 'undefined': {
  //       // false valid
  //       console.log('teste3');
  //       break;
  //     }
  //     case typeof nameFilterValue != 'undefined' &&
  //       typeof typeFilterValue != 'undefined': {
  //       //false false
  //       console.log('teste4');
  //       break;
  //     }
  //   }
  // }
}
