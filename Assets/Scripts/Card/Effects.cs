using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public GameController gamecontroller;
    public GameObject COCHand;
    public GameObject CRHand;

    void Start()
    {
        gamecontroller = GameObject.Find("GameController").GetComponent<GameController>();
        COCHand = GameObject.Find("COCHand");     
        CRHand = GameObject.Find("CRHand");
    }

    void Update()
    {
        
    }

    public void Effect(string keyword, GameObject go)
    {
        
        GameObject COCMelee = GameObject.Find("COCMelee");
        GameObject COCRange = GameObject.Find("COCRange");
        GameObject COCSiege = GameObject.Find("COCSiege");
        GameObject CRMelee = GameObject.Find("CRMelee");
        GameObject CRRange = GameObject.Find("CRRange");
        GameObject CRSiege = GameObject.Find("CRSiege");

        if (keyword == "mantener")
        {
            Debug.Log("Mantener");
        }

        if (keyword == "roba")
        { 

            if( go.transform.parent == COCHand.transform)   
            {
                Debug.Log("A");
                gamecontroller.COCDraw();
            }
            
            if (go.transform.parent == CRHand.transform)
            {
                Debug.Log("A");
                gamecontroller.CRDraw();
            }
        }

        if (keyword == "aumento")
        {
            if (go.transform.parent == COCHand.transform)
            {
                
            }
        }


    }
}
