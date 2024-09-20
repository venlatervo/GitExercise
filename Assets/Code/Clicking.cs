using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicking : MonoBehaviour
{
    public Button button;
    public TextScore textScore;

    public void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        textScore.IncreaseScore(1);
    }
}
