using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderEvents : MonoBehaviour
{
    public GameObject COCLeader;
    public GameObject CRLeader;
    public void OnClick()
    {
        COCLeader = GameObject.Find("COCLeader");
        CRLeader = GameObject.Find("CRLeader");
        if (gameObject.transform.parent == COCLeader.transform && TurnSystem.turn)
        {
            Debug.Log("Leader");
            TurnSystem.turn = !TurnSystem.turn;
        }
        if (gameObject.transform.parent == CRLeader.transform && !TurnSystem.turn)
        {
            Debug.Log("Leader");
            TurnSystem.turn = !TurnSystem.turn;
        }
        
    }
    
}
