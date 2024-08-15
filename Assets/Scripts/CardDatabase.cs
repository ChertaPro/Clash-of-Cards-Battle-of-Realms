using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cards = new List<Card>();

    void Awake()
    {
        cards.Add(new Card(0,"Reina Arquera","Lider",null,null,"mantener"));
        cards.Add(new Card(1,"Pekka","Heroe",'M',9,"+poder"));
        cards.Add(new Card(2,"Gran Centinela","Heroe",'R',7,"aumento"));
        cards.Add(new Card(3,"Rey Barbaro","Heroe",'M',8,"roba"));
        cards.Add(new Card(4,"Lanzarrocas","Plata",'R',4,"roba"));
        cards.Add(new Card(5,"Montapuercos","Plata",'M',6,"-poder"));
        cards.Add(new Card(6,"Bruja","Plata",'R',6,"+poder"));
        cards.Add(new Card(7,"Lanzatroncos","Plata",'S',4,"clima"));
        cards.Add(new Card(8,"Arrojapiedras","Plata",'S',7,"-poder"));
        cards.Add(new Card(9,"Hechizo de Rayo","Clima",null,null,"range"));
        cards.Add(new Card(10,"Montepuerco","Clima",null,null,"melee"));
        cards.Add(new Card(11,"Hechizo de furia","Aumento",null,null,"bonus"));
        cards.Add(new Card(12,"Taller del constructor","Aumento",null,null,"bonus"));
        cards.Add(new Card(13,"Controlador aereo","Despeje",null,null,"despeje"));
        cards.Add(new Card(14,"Tornado","Despeje",null,null,"despeje"));
        cards.Add(new Card(15,"Duende","Señuelo",null,0,"señuelo"));
        cards.Add(new Card(16,"Esbirro","Señuelo",null,0,"señuelo"));
        cards.Add(new Card(17,"Rey","Lider",null,null,"roba"));
        cards.Add(new Card(18,"Caballero dorado","Heroe",'M',8,"+poder"));
        cards.Add(new Card(19,"Gigante electrico","Heroe",'M',10,"clima"));
        cards.Add(new Card(20,"Gigante noble","Heroe",'R',7,"roba"));
        cards.Add(new Card(21,"Lanzafuegos","Plata",'R',5,"roba"));
        cards.Add(new Card(22,"Globo bombastico","Plata",'S',6,"+poder"));
        cards.Add(new Card(23,"Mosquetera","Plata",'R',4,"aumento"));
        cards.Add(new Card(24,"Cañon con ruedas","Plata",'S',5,"-poder"));
        cards.Add(new Card(25,"Arena Real","Aumento",null,null,"bonus"));
        cards.Add(new Card(26,"Espiritu de fuego","Despeje",null,null,"despeje"));
    }

}
