using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{   
    public bool turn ;
    public TextMeshProUGUI turntext;
    public int endturn;
    // Start is called before the first frame update
    void Start()
    {
        turn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (turn)
        {
            turntext.text = "Player 1";
        }
        else
        {
            turntext.text = "Player 2";
        }
    }

    public void Pass()
    {
        if (turn)
        {
            turn = false;
        }
        else
        {
            turn = true;
        }

        endturn ++;
        if (endturn == 2)
        {

        }
    }
}
