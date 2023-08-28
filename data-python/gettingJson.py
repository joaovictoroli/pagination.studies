import requests
import json
import os

pokedexNum = 1
#url = 'https://pokeapi.co/api/v2/pokemon/' + id
headers = {'Accept': 'application/json'}
auth = ('username', 'userpass')
#response = requests.get(url, headers=headers, auth=auth)

ROOT_DIR = os.path.dirname(os.path.abspath(__file__))

for x in range(1, 152):
    # send response to api and get json
    url = 'https://pokeapi.co/api/v2/pokemon/', x
    print(url)


def main_loop():
    for i in range (1, 152):
        pokedexNum = i
        headers = {'Accept': 'application/json'}
        url = 'https://pokeapi.co/api/v2/pokemon'
        new_url = "{}/{}".format(url, pokedexNum)
        response = requests.get(new_url, headers=headers)
        data = response.json()
        #print(data)
        with open(ROOT_DIR + '/jsonFiles/' + f'{pokedexNum}'+".json", 'w', encoding='utf-8') as f:
            json.dump(data, f, ensure_ascii=False, indent=4)


if __name__ == '__main__':
    main_loop()