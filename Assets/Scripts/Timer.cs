using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timeLeft = 100.0f;
    public Text text;

    // Update is called once per frame
    void Update()
    {
        // time goes backwards, Time.deltaTime
        timeLeft -= Time.deltaTime;
        text.text = "" + Mathf.Round(timeLeft);
        if(timeLeft < 0)
        {
            Debug.Log("GAME OVER");
        }
    }
}
