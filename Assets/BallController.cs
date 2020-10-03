using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
    GameObject director;
    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.director = GameObject.Find("GameDirector");
    }
    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
    void OnCollisionEnter(Collision other)
    {
        Debug.Log()
         
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.director.GetComponent<GameDirector>().GetSmallStar();
   
        }
        if (other.gameObject.tag == "LargeStarTag")
        {
            this.director.GetComponent<GameDirector>().GetLargeStar();
        }
        if (other.gameObject.tag == "SmallCloudTag")
        {
            this.director.GetComponent<GameDirector>().GetSmallCloud();
        }
        if (other.gameObject.tag == "LargeCloudTag")
        {
            this.director.GetComponent<GameDirector>().GetLargeCloud();
        }
    }
}