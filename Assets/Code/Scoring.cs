using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    int Rscore = 0;
    int Lscore = 0;
    bool RAwaspressed = false;
    bool LAwaspressed = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && !RAwaspressed)
        {
            Rscore++;
            RAwaspressed = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            RAwaspressed = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !LAwaspressed)
        {
            Lscore++;
            LAwaspressed = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            LAwaspressed = false;
        }
        Debug.Log("Score: " + Lscore + "and" + Rscore);

    }
}
