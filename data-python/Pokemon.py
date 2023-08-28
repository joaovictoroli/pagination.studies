class Pokemon:
  def __init__(self, name, pokedexNumber, type, imgUrl, type2 = None):
    self.id = pokedexNumber
    self.name = name
    self.pokedexNumber = pokedexNumber
    self.type = type
    self.type2 = type2
    self.imgUrl = imgUrl



  def __str__(self):
    if self.type2:
      return ("Name: " + self.name + "\n" +
            "PokedexNumber: " + str(self.pokedexNumber) + "\n" +
            "Type: " + self.type + "\n" +
            "Type2: " + self.type2 + "\n" 
            "ImgUrl: " + self.imgUrl)
    if not self.type2:
      return ("Name: " + self.name + "\n" +
          "PokedexNumber: " + str(self.pokedexNumber) + "\n" +
          "Type: " + self.type + "\n" +
          "Type2: " + "null" + "\n"
          "ImgUrl: " + self.imgUrl)
