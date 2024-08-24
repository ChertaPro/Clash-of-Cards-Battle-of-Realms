using System.Collections;
using System.Collections.Generic;
using Mono.Cecil;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cards = new List<Card>();

    void Awake()
    {
        cards.Add(new Card(0,"Reina Arquera","Lider",null,null,"mantener",Resources.Load<Sprite>("0-Reina Arquera")));
        cards.Add(new Card(1,"Pekka","Heroe",'M',9,"+poder",Resources.Load<Sprite>("1-Pekka")));
        cards.Add(new Card(2,"Gran Centinela","Heroe",'R',7,"aumento",Resources.Load<Sprite>("2-Gran Centinela")));
        cards.Add(new Card(3,"Rey Barbaro","Heroe",'M',8,"roba",Resources.Load<Sprite>("3-Rey Barbaro")));
        cards.Add(new Card(4,"Lanzarrocas","Plata",'R',4,"roba",Resources.Load<Sprite>("4-Lanzarrocas")));
        cards.Add(new Card(5,"Montapuercos","Plata",'M',6,"-poder",Resources.Load<Sprite>("5-Montapuercos")));//*! Neutral
        cards.Add(new Card(6,"Bruja","Plata",'R',6,"+poder",Resources.Load<Sprite>("6-Bruja")));
        cards.Add(new Card(7,"Lanzatroncos","Plata",'S',4,"clima",Resources.Load<Sprite>("7-Lanzatroncos")));
        cards.Add(new Card(8,"Arrojapiedras","Plata",'S',7,"-poder",Resources.Load<Sprite>("8-ArrojaPiedras")));
        cards.Add(new Card(9,"Hechizo de Rayo","Clima",null,null,"range",Resources.Load<Sprite>("9-Hechizo de Rayo")));//*! Neutral
        cards.Add(new Card(10,"Montepuerco","Clima",null,null,"melee",Resources.Load<Sprite>("10-Montepuerco")));//*! Neutral
        cards.Add(new Card(11,"Hechizo de furia","Aumento",null,null,"bonus",Resources.Load<Sprite>("11-Hechizo de Furia")));
        cards.Add(new Card(12,"Taller del constructor","Aumento",null,null,"bonus",Resources.Load<Sprite>("12-Taller del Constructor")));//*! Neutral
        cards.Add(new Card(13,"Controlador aereo","Despeje",null,null,"despeje",Resources.Load<Sprite>("13-Controlador Aereo")));
        cards.Add(new Card(14,"Tornado","Despeje",null,null,"despeje",Resources.Load<Sprite>("14-Tornado")));//*! Neutral
        cards.Add(new Card(15,"Duende","Señuelo",null,0,"señuelo",Resources.Load<Sprite>("15-Duende")));//*! Neutral
        cards.Add(new Card(16,"Esbirro","Señuelo",null,0,"señuelo",Resources.Load<Sprite>("16-Esbirro")));//*! Neutral
        cards.Add(new Card(17,"Rey","Lider",null,null,"roba",Resources.Load<Sprite>("17-Rey")));
        cards.Add(new Card(18,"Caballero dorado","Heroe",'M',8,"+poder",Resources.Load<Sprite>("18-Caballero Dorado")));
        cards.Add(new Card(19,"Gigante electrico","Heroe",'M',10,"clima",Resources.Load<Sprite>("19-Gigante Electrico")));
        cards.Add(new Card(20,"Gigante noble","Heroe",'R',7,"roba",Resources.Load<Sprite>("20-Gigante Noble")));
        cards.Add(new Card(21,"Lanzafuegos","Plata",'R',5,"roba",Resources.Load<Sprite>("21-Lanzafuegos")));
        cards.Add(new Card(22,"Globo bombastico","Plata",'S',6,"+poder",Resources.Load<Sprite>("22-Globo Bombástico")));
        cards.Add(new Card(23,"Mosquetera","Plata",'R',4,"aumento",Resources.Load<Sprite>("23-Mosquetera")));
        cards.Add(new Card(24,"Cañon con ruedas","Plata",'S',5,"-poder",Resources.Load<Sprite>("24-Cañon con Ruedas")));
        cards.Add(new Card(25,"Arena Real","Aumento",null,null,"bonus",Resources.Load<Sprite>("25-Arena real")));
        cards.Add(new Card(26,"Espiritu de fuego","Despeje",null,null,"despeje",Resources.Load<Sprite>("26-Espiritu de fuego")));
    }

    void Start()
    {
        
    }

}
