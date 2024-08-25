using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.UI;

public class LeaderEvents : MonoBehaviour
{
    public GameObject COCLeader;
    public GameObject CRLeader;
    public GameObject Cardstats;
    public TextMeshProUGUI Powerstat;
    public Image Cardimage;
    public void OnClick()
    {
        COCLeader = GameObject.Find("COCLeader");
        CRLeader = GameObject.Find("CRLeader");
        if (gameObject.transform.parent == COCLeader.transform && TurnSystem.turn == 1)
        {
            TurnSystem.turn = 0;
        }
        if (gameObject.transform.parent == CRLeader.transform && TurnSystem.turn == 0)
        {
            TurnSystem.turn = 1;
        }
        
    }

    public void HoverEnter()
    {
        Cardstats = GameObject.Find("Stats");
        Cardimage = Cardstats.GetComponent<Image>();
        GameObject hideObject = Cardstats.transform.Find("Hide")?.gameObject;
        Powerstat = hideObject.transform.Find("Power")?.GetComponent<TextMeshProUGUI>();
        CardDisplay stats= gameObject.GetComponent<CardDisplay>();
        Cardimage.sprite = stats.spriteimage;
        Powerstat.text = stats.power.ToString();
    }
    
}
