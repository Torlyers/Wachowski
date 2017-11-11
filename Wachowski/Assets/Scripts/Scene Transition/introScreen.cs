using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void startGame()
    {
        SceneManager.LoadScene("LevelBuild");
    }

    public void exitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }
}
