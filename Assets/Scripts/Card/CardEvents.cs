using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CardEvents : MonoBehaviour
{
    public GameObject Playercard;

    [HideInInspector]
    public GameObject Field;

    public List<string> COCaumentos = new List<string>();
    public List<string> CRaumentos = new List<string>();
    private void Start() 
    {
        COCaumentos.Add("COCAumento (M)");
        COCaumentos.Add("COCAumento (R)");
        COCaumentos.Add("COCAumento (S)");
        CRaumentos.Add("CRAumento (M)");
        CRaumentos.Add("CRAumento (R)");
        CRaumentos.Add("CRAumento (S)");
    }
    public void Click()
    {
        GameObject COCHand = GameObject.Find("COCHand");
        GameObject CRHand = GameObject.Find("CRHand");

        if (Playercard.transform.parent == COCHand.transform)
        {
            CardDisplay cardDisplay = Playercard.GetComponent<CardDisplay>();
            if (cardDisplay.attack_type == 'M' )
            {
                Field = GameObject.Find("COCMelee");
                Playercard.transform.SetParent(Field.transform, false);
            }
            else if (cardDisplay.attack_type == 'R' )
            {
                Field = GameObject.Find("COCRange");
                Playercard.transform.SetParent(Field.transform, false);
            }
            else if (cardDisplay.attack_type == 'S' )
            {
                Field = GameObject.Find("COCSiege");
                Playercard.transform.SetParent(Field.transform, false);
            }
            else if (cardDisplay.cardtype == "Clima" )
            {
                Field = GameObject.Find("ClimaZone");
                Playercard.transform.SetParent(Field.transform, false);
            }
            else if (cardDisplay.cardtype == "Aumento" )
            {
                List<string> aumentos = COCaumentos;
                int random;
                random = Random.Range(0, aumentos.Count);
                Debug.Log(random);
                Field = GameObject.Find(aumentos[random]);
                Playercard.transform.SetParent(Field.transform, false);
                COCaumentos.RemoveAt(random);
            }
            else if (cardDisplay.cardtype == "Despeje")
            {

            }
            else if (cardDisplay.cardtype == "Señuelo")
            {

            }
        }

        if (Playercard.transform.parent == CRHand.transform)
        {
            CardDisplay cardDisplay = Playercard.GetComponent<CardDisplay>();
            if (cardDisplay.attack_type == 'M' )
            {
                Field = GameObject.Find("CRMelee");
                Playercard.transform.SetParent(Field.transform, false);
            }
            else if (cardDisplay.attack_type == 'R' )
            {
                Field = GameObject.Find("CRRange");
                Playercard.transform.SetParent(Field.transform, false);
            }
            else if (cardDisplay.attack_type == 'S' )
            {
                Field = GameObject.Find("CRSiege");
                Playercard.transform.SetParent(Field.transform, false);
            }
            else if (cardDisplay.cardtype == "Clima" )
            {
                Field = GameObject.Find("ClimaZone");
                Playercard.transform.SetParent(Field.transform, false);
            }
            else if (cardDisplay.cardtype == "Aumento" )
            {
                List<string> aumentos = CRaumentos;
                int random ;
                random = Random.Range(0, aumentos.Count);
                Field = GameObject.Find(aumentos[random]);
                Playercard.transform.SetParent(Field.transform, false);
                CRaumentos.RemoveAt(random);
            }
            else if (cardDisplay.cardtype == "Despeje")
            {

            }
            else if (cardDisplay.cardtype == "Señuelo")
            {
                
            }
        }
    }
}
