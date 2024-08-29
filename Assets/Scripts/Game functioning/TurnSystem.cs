using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{   
    public static int turn ;
    public TextMeshProUGUI turntext;
    public bool COCturn;
    public bool CRturn;
    public GameController gamecontroller;
    public GameObject Field;
    public List<string> zones = new List<string>();
    public int intcocwins;
    public int intcrwins;
    public TextMeshProUGUI COCWins;
    public TextMeshProUGUI CRWins;
    public GameObject EndGamePanel;
    public TextMeshProUGUI Winnertext;

    

    // Start is called before the first frame update
    void Start()
    {
        gamecontroller = GameObject.Find("GameController").GetComponent<GameController>();
        EndGamePanel = GameObject.Find("End");
        EndGamePanel.SetActive(false);
        zones.Add("COCMelee");
        zones.Add("COCRange");
        zones.Add("COCSiege");
        zones.Add("CRMelee");
        zones.Add("CRRange");
        zones.Add("CRSiege");
        zones.Add("COCAumento (M)");
        zones.Add("COCAumento (R)");
        zones.Add("COCAumento (S)");
        zones.Add("CRAumento (M)");
        zones.Add("CRAumento (R)");
        zones.Add("CRAumento (S)");
        zones.Add("ClimaZone");
        turn = 1;
        COCturn = false;
        CRturn = false;
    }

    // Update is called once per frame
    void Update()
    {
        TextButton();
        Endturn();
        EndRound();
        Stop();

    }

    public void Pass()
    {
        if (turn == 1)
        {
            turn = 0;
            COCturn = true;
        }
        else if (turn == 0)
        {
            turn = 1;
            CRturn = true;
        }

    }

    void TextButton()
    {
        if (turn == 1)
        {
            turntext.text = "Player 1";
        }
        else if (turn == 0)
        {
            turntext.text = "Player 2";
        }
        else if (turn == 2)
        {
            turntext.text = "END";
        }
    }

    void Endturn()
    {
        if(COCturn && !CRturn)
        {
            turn = 0;
        }

        if (CRturn && !COCturn)
        {
            turn = 1;
        }

        if (COCturn && CRturn)
        {
            turn = 2;
        }
    }

    void EndRound()
    {
        if(turn == 2)
        {
            gamecontroller.COCDraw();
            gamecontroller.CRDraw();
            gamecontroller.COCDraw();
            gamecontroller.CRDraw();
            Winner();
            DestroyCards();
            COCturn = false;
            CRturn = false;
        }
    }
    void DestroyCards()
    {
        foreach (string zone in zones)
            {
                Field = GameObject.Find(zone);
                if (Field.transform.childCount > 0)
                {
                    foreach(Transform card in Field.transform)
                    {
                        CardDisplay keep = card.GetComponent<CardDisplay>();
                        if (!keep.keepingbool)
                        {
                            Destroy(card.gameObject);
                        }
                    }
                }
            }
    }

    void Winner()
    {
        if (GameController.staticCOCpower > GameController.staticCRpower)
        {
            intcocwins+=1;
            COCWins.text ="Wins : " + intcocwins.ToString();
            turn = 1;
            LeaderEvents.COCLeaderEffect = true;
            LeaderEvents.CRLeaderEffect = true;
        }
        if (GameController.staticCOCpower < GameController.staticCRpower)
        {
            intcrwins+=1;
            CRWins.text = "Wins : " + intcrwins.ToString();
            turn = 0;
            LeaderEvents.COCLeaderEffect = true;
            LeaderEvents.CRLeaderEffect = true;
        }
        if (GameController.staticCOCpower == GameController.staticCRpower)
        {
            intcocwins+=1;
            intcrwins+=1;
            COCWins.text = "Wins : "+ intcocwins.ToString();
            CRWins.text =  "Wins : " + intcrwins.ToString();
            turn = 1;
            LeaderEvents.COCLeaderEffect = true;
            LeaderEvents.CRLeaderEffect = true;
        }
    }

    void Stop()
    {
        if (intcocwins == 2 )
        {
            EndGamePanel.SetActive(true);
            Winnertext.text = "Clash of Clans Wins";
        }
        if (intcrwins == 2)
        {
            EndGamePanel.SetActive(true);
            Winnertext.text = "Clash Royale Wins";
        }
        if (intcrwins == 2 && intcocwins == 2)
        {
            EndGamePanel.SetActive(true);
            Winnertext.text = "It's a Tie";
        }
    }
}
