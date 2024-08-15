using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardDisplay : MonoBehaviour
{
    public Card displaycard;
    public int displayid;
    public int id;
    public string cardname;
    public string cardtype;
    public char? attack_type;
    public int? power;
    public string effect;
    public Sprite spriteimage;

    public Image show;


    // Start is called before the first frame update
    void Start()
    {
        displaycard = CardDatabase.cards[displayid];
        id = displaycard.id;
        cardname = displaycard.cardname;
        cardtype = displaycard.cardtype;
        attack_type = displaycard.attack_type;
        power = displaycard.power;
        effect = displaycard.effect;
        spriteimage = displaycard.spriteimage;
        show.sprite = spriteimage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
