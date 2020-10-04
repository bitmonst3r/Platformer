using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timeLeft = 100.0f;
    public Text text;
    public Text gameOver;

    // Update is called once per frame
    void Update()
    {
        gameOver.gameObject.SetActive(false);

        // time goes backwards, Time.deltaTime
        timeLeft -= Time.deltaTime;
        text.text = "" + Mathf.Round(timeLeft);
        if(timeLeft < 0)
        {
            gameOver.gameObject.SetActive(true);
        }
    }
}
