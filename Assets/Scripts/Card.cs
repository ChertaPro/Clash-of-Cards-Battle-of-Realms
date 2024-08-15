using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card 
{
    public int id;
    public string cardname;
    public string cardtype;
    public char? attack_type;
    public int? power;
    public string effect;


    public Card()
    {

    }

    public Card(int Id, string Cardname,string Cardtype, char? Attack_type,int? Power,string Effect)
    {
        this.id = Id;
        this.cardname = Cardname;
        this.cardtype = Cardtype;
        this.attack_type = Attack_type;
        this.power = Power;
        this.effect = Effect;
    }
    
}
