import os
import json
from Pokemon import Pokemon

ROOT_DIR = os.path.dirname(os.path.abspath(__file__))
pokedexNum = 1
jsonFile = ROOT_DIR + '/jsonFiles/' + f'{pokedexNum}'+".json"

def obj_dict(obj):
    return obj.__dict__


def main_loop():
    listPokemon = []
    ROOT_DIR = os.path.dirname(os.path.abspath(__file__))

    for i in range (1,152):
        pokedexNum = i
        jsonFile = ROOT_DIR + '/jsonFiles/' + f'{pokedexNum}' + ".json"
        with open(jsonFile) as jsonFile:
            data = jsonFile.read()
            obj = json.loads(data)
        #print(data)

        #print(obj['types'][1]['type']['name'])
        #print(obj['sprites']['front_default'])

        name = obj['name']
        id = obj['id']
        type = obj['types'][0]['type']['name']
        imgUrl = obj['sprites']['front_default']

        type2 = False
        try:
            type2 = obj['types'][1]['type']['name']
            p = Pokemon(name, id, type, imgUrl=imgUrl, type2=type2)
            #listPokemon.append(p)
        except:
            print("this pokemon has no second type")
            p = Pokemon(name, id, type=type, imgUrl=imgUrl, type2="")
            #listPokemon.append(p)

        #if not type2:
          #  p = Pokemon(name, id, type=type, imgUrl=imgUrl, type2="")

        #print(p.__str__())
        listPokemon.append(p)

    for pokemon in listPokemon:
        print(pokemon)

    json_string = json.dumps(listPokemon, default=obj_dict, indent=4)

    with open(ROOT_DIR + "/jsonFilesManipulated/seed.json", 'w') as outfile:
        outfile.write(json_string)

if __name__ == '__main__':
    main_loop()