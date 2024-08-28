using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public GameObject clone;
    public GameController gamecontroller;
    public GameObject COCHand;
    public GameObject CRHand;
    public GameObject Field;
    public GameObject Field2;
    public List<string> COCaumentos = new List<string>();
    public List<string> CRaumentos = new List<string>();  
    public List<string> zones = new List<string>();  
    void Start()
    {
        gamecontroller = GameObject.Find("GameController").GetComponent<GameController>();
        COCHand = GameObject.Find("COCHand");     
        CRHand = GameObject.Find("CRHand");
        COCaumentos.Add("COCAumento (M)");
        COCaumentos.Add("COCAumento (R)");
        COCaumentos.Add("COCAumento (S)");
        CRaumentos.Add("CRAumento (M)");
        CRaumentos.Add("CRAumento (R)");
        CRaumentos.Add("CRAumento (S)");
        zones.Add("COCMelee");
        zones.Add("COCRange");
        zones.Add("COCSiege");
        zones.Add("CRMelee");
        zones.Add("CRRange");
        zones.Add("CRSiege");
    }

    void Update()
    {
        
    }

    public void Effect(string keyword, GameObject go)
    {
        if (keyword == "mantener")
        {
            Debug.Log("Mantener");
        }

        if (keyword == "roba")
        { 

            if( go.transform.parent == COCHand.transform)   
            {
                gamecontroller.COCDraw();
            }
            
            if (go.transform.parent == CRHand.transform)
            {
                gamecontroller.CRDraw();
            }
        }

        if (keyword == "aumento")
        {
            if (go.transform.parent == COCHand.transform)
            {
                foreach (Transform aumento in COCHand.transform)
                {
                    CardDisplay type = aumento.GetComponent<CardDisplay>();
                    if (type.cardtype == "Aumento")
                    {
                        List<string> aumentos = COCaumentos;
                        int random ;
                        random = Random.Range(0, aumentos.Count);
                        Field = GameObject.Find(aumentos[random]);
                        aumento.transform.SetParent(Field.transform, false);
                        COCaumentos.RemoveAt(random);
                        break;
                    }
                    
                }
            }
            if (go.transform.parent == CRHand.transform)
            {
                foreach (Transform aumento in CRHand.transform)
                {
                    CardDisplay type = aumento.GetComponent<CardDisplay>();
                    if (type.cardtype == "Aumento")
                    {
                        List<string> aumentos = CRaumentos;
                        int random ;
                        random = Random.Range(0, aumentos.Count);
                        Field = GameObject.Find(aumentos[random]);
                        aumento.transform.SetParent(Field.transform, false);
                        CRaumentos.RemoveAt(random);
                        break;
                    }
                    
                }
            }
        }
        
        if (keyword == "clima")
        {
            if (go.transform.parent == COCHand.transform)
            {
                foreach (Transform clima in COCHand.transform)
                {
                    CardDisplay type = clima.GetComponent<CardDisplay>();
                    if (type.cardtype == "Clima")
                    {
                        Field = GameObject.Find("ClimaZone");
                        clima.transform.SetParent(Field.transform, false);
                        break;
                    }
                    
                }
            }
            if (go.transform.parent == CRHand.transform)
            {
                foreach (Transform clima in CRHand.transform)
                {
                    CardDisplay type = clima.GetComponent<CardDisplay>();
                    
                    if (type.cardtype == "Clima")
                    {
                        Field = GameObject.Find("ClimaZone");
                        clima.transform.SetParent(Field.transform, false);
                        break;
                    }
                    
                }
            }
        }

        if (keyword == "+poder")
        {
            if (go.transform.parent == COCHand.transform || go.transform.parent == CRHand.transform)
            { 
                GameObject COCgraveyard = GameObject.Find("COCGraveyard");
                GameObject CRgraveyard = GameObject.Find("CRGraveyard");
                Transform destroy = go.transform;
                
                foreach (string zone in zones)
                {
                    Field = GameObject.Find(zone);
                    foreach (Transform card in Field.transform)
                    {
                        CardDisplay power = card.GetComponent<CardDisplay>();
                        CardDisplay destroypower = destroy.GetComponent<CardDisplay>();
                        if(power.power > destroypower.power)
                        {
                            destroy = card;
                        }
                    }
                }
                for (int i = 0;i<3;i++)
                {
                    Field = GameObject.Find(zones[i]);
                    if(destroy.parent == Field.transform || destroy.parent == COCHand.transform)
                    {
                        CardDisplay graveyard = destroy.GetComponent<CardDisplay>();
                        graveyard.attack_type = 'g';//Para que no tome ninguno de los valores de la funcion de click y le vuelvva a cambiar el padre a una row del trablero
                        destroy.SetParent(COCgraveyard.transform,false);
                        break;
                    }
                }
                for (int i = 3;i<6;i++)
                {
                    Field = GameObject.Find(zones[i]);
                    if(destroy.parent == Field.transform || destroy.parent == CRHand.transform)
                    {
                        CardDisplay graveyard = destroy.GetComponent<CardDisplay>();
                        graveyard.attack_type = 'g';
                        destroy.SetParent(CRgraveyard.transform,false);
                        break;
                    }
                }
                //Destroy(destroy.gameObject,1f);
            }
            
        }

        if (keyword == "-poder")
        {
            if (go.transform.parent == COCHand.transform)
            {
                GameObject CRgraveyard = GameObject.Find("CRGraveyard");
                Transform destroy = go.transform;
                CardDisplay destroypower = destroy.GetComponent<CardDisplay>();
                destroypower.power = 100;
                for (int i = 3;i<6;i++)
                {
                    Field = GameObject.Find(zones[i]);
                    foreach (Transform card in Field.transform)
                    {
                        CardDisplay power = card.GetComponent<CardDisplay>();
                        if(power.power < destroypower.power)
                        {
                            destroypower.power = power.power;
                            destroy = card;
                        }
                    }
                }
                
                destroy.SetParent(CRgraveyard.transform,false);    
            }
            if (go.transform.parent == CRHand.transform)
            {
                GameObject COCgraveyard = GameObject.Find("COCGraveyard");
                Transform destroy = go.transform;
                CardDisplay destroypower = destroy.GetComponent<CardDisplay>();
                destroypower.power = 100;
                for (int i = 0;i<3;i++)
                {
                    Field = GameObject.Find(zones[i]);
                    foreach (Transform card in Field.transform)
                    {
                        CardDisplay power = card.GetComponent<CardDisplay>();
                        if(power.power < destroypower.power)
                        {
                            destroypower.power = power.power;
                            destroy = card;
                        }
                    }
                }
                destroy.SetParent(COCgraveyard.transform,false);    
            }
        }

        if (keyword == "melee")
        {
            Field = GameObject.Find(zones[0]);
            Field2 = GameObject.Find(zones[3]);
            if (Field.transform.childCount > 0)
            {
                foreach (Transform card in Field.transform)
                {
                    CardDisplay clima = card.GetComponent<CardDisplay>();
                    if(clima.climabool)
                    {
                        CardDatabase.cards[clima.displayid].power -=2;
                        CardDatabase.cards[clima.displayid].climabool = false;
                    }
                }
            } 
            if (Field2.transform.childCount > 0)
            {   
                foreach (Transform card in Field2.transform)
                {
                    CardDisplay clima = card.GetComponent<CardDisplay>();
                    if(clima.climabool)
                    {
                        CardDatabase.cards[clima.displayid].power -=2;
                        CardDatabase.cards[clima.displayid].climabool = false;
                    }
                }
            }    

        }

        if (keyword == "range")
        {
            Field = GameObject.Find(zones[1]);
            Field2 = GameObject.Find(zones[4]);
            if (Field.transform.childCount > 0)
            {
                foreach (Transform card in Field.transform)
                {
                    CardDisplay clima = card.GetComponent<CardDisplay>();
                    if(clima.climabool)
                    {
                        CardDatabase.cards[clima.displayid].power -=2;
                        CardDatabase.cards[clima.displayid].climabool = false;
                    }
                }
            }
            if (Field2.transform.childCount > 0)
            {
                foreach (Transform card in Field2.transform)
                {
                    CardDisplay clima = card.GetComponent<CardDisplay>();
                    if(clima.climabool)
                    {
                        CardDatabase.cards[clima.displayid].power -=2;
                        CardDatabase.cards[clima.displayid].climabool = false;
                    }
                }
            }
        }

        if (keyword == "bonus")
        {
            for (int i = 0;i<3;i++)
            {
                Field = GameObject.Find(COCaumentos[i]);
                if (go.transform.parent == Field.transform)
                {
                    Field2 = GameObject.Find(zones[i]);
                    if(Field2.transform.childCount > 0)
                    {
                        foreach(Transform card in Field2.transform)
                        {
                            CardDisplay aum = card.GetComponent<CardDisplay>();
                            if(aum.aumentobool)
                            {
                                CardDatabase.cards[aum.displayid].power += 2;
                                CardDatabase.cards[aum.displayid].aumentobool = false;
                            }
                        }
                    }
                }
            }
            for (int i = 0;i<3;i++)
            {
                Field = GameObject.Find(CRaumentos[i]);
                if (go.transform.parent == Field.transform)
                {
                    Field2 = GameObject.Find(zones[i+3]);
                    if(Field2.transform.childCount > 0)
                    {
                        foreach(Transform card in Field2.transform)
                        {
                            CardDisplay aum = card.GetComponent<CardDisplay>();
                            if(aum.aumentobool)
                            {
                                CardDatabase.cards[aum.displayid].power += 2;
                                CardDatabase.cards[aum.displayid].aumentobool = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
