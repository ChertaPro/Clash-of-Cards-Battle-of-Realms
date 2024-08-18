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

//**-------------------CardBack---------------------------------------
    public bool coccardback;
    public bool crcardback;
    public static bool cocstaticcardback;
    public static bool crstaticcardback;
//**-------------------Hand---------------------------------------
    public GameObject Hand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        COCDisplayHand();
        CRDisplayHand();
        Display();
        cocstaticcardback = coccardback;
        crstaticcardback = crcardback;

    }
    void Display()
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

    void COCDisplayHand()
    {
        Hand = GameObject.Find("COCHand");
        if (this.transform.parent == Hand.transform.parent)
        {
            coccardback = false;
            crcardback = false;
        }

        if (this.tag == "COCHandCard")
        {
            displayid = COCDeck.Staticdeck1[0].id;
            COCDeck.Staticdeck1.RemoveAt(0);
            coccardback = false;
            crcardback = false;
            this.tag = "Untagged";
        }
    }
    void CRDisplayHand()
    {
        Hand = GameObject.Find("CRHand");
        if (this.transform.parent == Hand.transform.parent)
        {
            coccardback = false;
            crcardback = false;
        }

        if (this.tag == "CRHandCard")
        {
            displayid = CRDeck.Staticdeck2[0].id;
            CRDeck.Staticdeck2.RemoveAt(0);
            coccardback = false;
            crcardback = false;
            this.tag = "Untagged";
        }
    }
}
