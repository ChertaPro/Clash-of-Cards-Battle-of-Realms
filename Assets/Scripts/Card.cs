using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    public int id;
    public string cardname;

    public char attack_type;

    public int power;

    public string effect;

    public Card()
    {

    }

    public Card(int Id, string Cardame,char Attack_type,int Power,string Effect)
    {
        this.id = Id;
        this.cardname = Cardame;
        this.attack_type = Attack_type;
        this.power = Power;
        this.effect = Effect;
    }
    
}
