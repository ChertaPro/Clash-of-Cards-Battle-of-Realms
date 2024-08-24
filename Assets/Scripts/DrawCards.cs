using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Drawcard;
    public  GameObject Hand;
    public List<GameObject> COCHandCards = new List<GameObject>();
    public List<GameObject> CRHandCards = new List<GameObject>();

    public static List<GameObject> staticCOCHandcards = new List<GameObject>();
    public static List<GameObject> staticCRHandcards = new List<GameObject>();


    void Start()
    {
        StartCoroutine("DrawCardsWithDelay");
    }

    void Update()
    {
        COCHandCards = staticCOCHandcards;
        CRHandCards = staticCRHandcards;
    }

    void Draw()
    {        
        GameObject playercard = Instantiate(Drawcard,new Vector3(0, 0, 0), Quaternion.identity);
        playercard.transform.SetParent(Hand.transform,false);
    }

    // Corrutina que llama a Draw con un delay de 1 segundo entre cada llamada
    IEnumerator DrawCardsWithDelay()
    {
        for (int i = 0; i < 10; i++)
        {       
            Draw();
            yield return new WaitForSeconds(0.3f); // Espera 1 segundo antes de continuar con el siguiente ciclo
        }
    }
}
