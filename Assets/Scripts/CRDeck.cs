using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRDeck : MonoBehaviour
{
    public List<Card> Deck2 = new List<Card>();
    public List<int> Ids = new List<int>{5,5,5,9,10,12,14,15,16,18,19,20,21,21,21,22,22,22,23,23,23,24,24,24,25,26};
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
                    Deck2.Add(CardDatabase.cards[j]);
                }
            }
        }
    }
}
