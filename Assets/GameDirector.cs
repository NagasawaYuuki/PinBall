using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameDirector : MonoBehaviour
{
    private GameObject scoreText;
    int score = 0;

    public void GetSmallStar()
    {
        this.score += 50;
    }
    public void GetLargeStar()
    {
        this.score += 150;
    }
    public void GetSmallCloud()
    {
        this.score += 100;
    }
    public void GetLargeCloud()
    {
        this.score += 200;
    }
    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text = "score : " + this.score;

    }
}
