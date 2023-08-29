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
  varNameFilter: string = '';
  varTypeFilter: string = '';
  pokemons: Pokemon[] | undefined;
  pageNumber = 1;
  pageSize = 10;
  totalItens = 151;

  constructor(private pokemonService: PokemonService, private router: Router) {}

  ngOnInit(): void {
    this.filtering(this.nameFilterValue!, this.typeFilterValue!);
  }

  pageChanged(event: PageChangedEvent) {
    if (this.pageNumber !== event.page) {
      this.pageNumber = event.page;
      this.filtering(this.nameFilterValue!, this.typeFilterValue!);
    }
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

    var teste = this.pokemonService.getPokemonsAllInOne(queryParams).subscribe({
      next: (response) => {
        if (response.result && response.pagination) {
          this.pokemons = response.result;
          this.totalItens = response.pagination.totalItems;
        }
      },
    });
  }
}
