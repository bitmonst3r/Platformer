using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text scoreText;
    public Text coinsText;
    public Text gameOver;
    public int score = 0;
    public int coins = 0;
    public AudioClip coinClip;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Brick(Clone)")
        {
            Destroy(collision.gameObject);
            score = score + 100;
            scoreText.text = "00" + score;
        }

        if (collision.gameObject.name == "QuestionBlock(Clone)")
        {
            Destroy(collision.gameObject);
            coins = coins + 1;
            coinsText.text = "x " + coins;
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = coinClip;
            audio.Play();
            score = score + 100;
            scoreText.text = "00" + score;
        }

        if (collision.gameObject.name == "Lava(Clone)")
        {
            Debug.Log("Player falied");
        }

        if (collision.gameObject.name == "Goal(Clone)")
        {
            Debug.Log("Yay! You passed level 2");
        }
    }
}
