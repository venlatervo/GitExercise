using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    int score = 0;
    bool clicked = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !clicked)
        {
            score++;
            clicked = true;
        }
        else if (!Input.GetMouseButtonDown(0))
        {
            clicked = false;
        }
        Debug.Log("Score: " + score);
        
    }
}
