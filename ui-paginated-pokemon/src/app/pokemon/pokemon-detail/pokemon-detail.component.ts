import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { PokemonService } from 'src/app/_services/pokemon.service';
import { Pokemon } from 'src/app/models/pokemon';

@Component({
  selector: 'app-pokemon-detail',
  templateUrl: './pokemon-detail.component.html',
  styleUrls: ['./pokemon-detail.component.css'],
})
export class PokemonDetailComponent implements OnInit {
  pokemon: Observable<Pokemon> | undefined;
  pokemonId: string | undefined;

  constructor(
    private pokemonService: PokemonService,
    private route: ActivatedRoute
  ) {}
  ngOnInit(): void {
    this.pokemonId = this.route.snapshot.params['pokemonId'];
    this.pokemon = this.pokemonService.getPokemonDetail(this.pokemonId!);
  }
}
