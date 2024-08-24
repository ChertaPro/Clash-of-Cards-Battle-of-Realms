using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject card;
    public GameObject COCHand;
    public GameObject CRHand;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DrawCardsWithDelay");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Draw()
    {   
        COCHand = GameObject.Find("COCHand"); 
        CRHand = GameObject.Find("CRHand");    
        GameObject COCcard = Instantiate(card,new Vector3(0, 0, 0), Quaternion.identity);
        COCcard.transform.SetParent(COCHand.transform,false);
        GameObject CRcard = Instantiate(card,new Vector3(0, 0, 0), Quaternion.identity);
        CRcard.transform.SetParent(CRHand.transform,false);

        
    }
    IEnumerator DrawCardsWithDelay()
    {
        for (int i = 0; i < 10; i++)
        {       
            Draw();
            yield return new WaitForSeconds(0.3f); // Espera 1 segundo antes de continuar con el siguiente ciclo
        }
    }


    




}
