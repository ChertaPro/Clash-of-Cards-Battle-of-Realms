using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class COCDeck : MonoBehaviour
{
    public List<Card> Deck1 = new List<Card>();
    public List<int> Ids = new List<int>{1,2,3,4,4,4,5,5,5,6,6,6,7,7,7,8,8,8,9,10,11,12,13,14,15,16};
    public int randomid;

    // Start is called before the first frame update
    void Start()
    {
        Shuffle(Ids);
        GetCards();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Shuffle(List<int> Ids)
    {
        int temp = 0;
        for (int i = 0;i<Ids.Count;i++)
        {
            randomid = Random.Range(0, Ids.Count);
            temp = Ids[i];
            Ids[i] = Ids[randomid];
            Ids[randomid] = temp;
        }
    }    

    void GetCards()
    {
        for (int i = 0;i<Ids.Count;i++)
        {
            for(int j = 0;j<CardDatabase.cards.Count;j++)
            {
                if (CardDatabase.cards[j].id == Ids[i])
                {
                    Deck1.Add(CardDatabase.cards[j]);
                }
            }
        }
    }
}
