using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreController : MonoBehaviour {

    public Text scoreText;
    private int score;
    // Use this for initialization
	void Start () {
        GameMain.Instance.score = 0;
        scoreText.text = "Score: " + GameMain.Instance.score;
	}
	
	// Update is called once per frame
	void Update () {
        GameMain.Instance.score += 2;
        scoreText.text = "Score: " + GameMain.Instance.score;
	}
}
