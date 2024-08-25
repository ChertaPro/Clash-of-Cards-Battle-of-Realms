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

    // Start is called before the first frame update
    void Start()
    {
        turn = 1;
        COCturn = false;
        CRturn = false;
    }

    // Update is called once per frame
    void Update()
    {
        TextButton();
        Endturn();

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
}
