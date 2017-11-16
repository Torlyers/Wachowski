using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Text finalScore;
    // Use this for initialization
	void Start () {
        finalScore.text = "SCORE:" + ScoreBoard.score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
