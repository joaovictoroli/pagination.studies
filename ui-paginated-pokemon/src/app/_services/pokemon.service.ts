import { Injectable } from '@angular/core';
import { Pokemon } from '../models/pokemon';
import { environment } from '../environments/environment';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable, map } from 'rxjs';
import { PaginatedResult } from '../models/paginationResult';
import { QueryParams } from '../models/queryParams';

@Injectable({
  providedIn: 'root',
})
export class PokemonService {
  baseUrl = environment.apiUrl;
  pokemons: Pokemon[] = [];
  pokemon?: Pokemon | undefined;
  constructor(private http: HttpClient) {}

  getPokemons(pageNumber: number, ItemsInPage: number) {
    let params = new HttpParams()
      .set('PageNumber', pageNumber)
      .set('ItemsInPage', ItemsInPage);

    var url = this.baseUrl + 'pokemons';

    return this.getPaginatedResult<Pokemon[]>(url, params, this.http).pipe(
      map((response) => {
        return response;
      })
    );
  }

  nameFiltering(typeFilter: string, pageNumber: number, ItemsInPage: number) {
    let params = new HttpParams()
      .set('nameFilter', typeFilter)
      .set('PageNumber', pageNumber)
      .set('ItemsInPage', ItemsInPage);

    var url = this.baseUrl + 'pokemons/filterByName';

    return this.getPaginatedResult<Pokemon[]>(url, params, this.http).pipe(
      map((response) => {
        return response;
      })
    );
  }

  getPaginatedResult<T>(url: string, params: HttpParams, http: HttpClient) {
    const paginatedResult: PaginatedResult<T> = new PaginatedResult<T>();
    return http.get<T>(url, { observe: 'response', params }).pipe(
      map((response) => {
        if (response.body) {
          paginatedResult.result = response.body;
        }
        const pagination = response.headers.get('Pagination');
        if (pagination) {
          paginatedResult.pagination = JSON.parse(pagination);
        }
        return paginatedResult;
      })
    );
  }

  //detaiil
  getPokemonDetail(pokemonId: string) {
    return this.http.get<Pokemon>(this.baseUrl + 'pokemons/' + pokemonId).pipe(
      map((pokemon) => {
        this.pokemon = pokemon;
        return pokemon;
      })
    );
  }

  // new pokemon-list

  getPokemonsAllInOne(queryParams: QueryParams) {
    console.log(queryParams.typeFilter);
    var params = this.setParams(queryParams);
    var url = this.baseUrl + 'pokemons/allInOne';
    console.log(params);
    return this.getPaginatedResult<Pokemon[]>(url, params, this.http).pipe(
      map((response) => {
        return response;
      })
    );
  }
  setParams(queryParams: QueryParams) {
    let params = new HttpParams()
      .set('PageNumber', queryParams.PageNumber!)
      .set('ItemsInPage', queryParams.ItemsInPage!);

    if (queryParams.nameFilter != '') {
      params = params.set('nameFilter', queryParams.nameFilter!);
    }
    if (
      queryParams.typeFilter != '' &&
      typeof queryParams.typeFilter != 'undefined'
    ) {
      params = params.set('typeFilter', queryParams.typeFilter!);
    }

    return params;
  }
}
