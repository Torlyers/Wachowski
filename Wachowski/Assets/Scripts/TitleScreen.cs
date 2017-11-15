using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {

	
    public void startGame()
    {
        SceneManager.LoadScene("LevelBuild");
    }
    public void endGame()
    {
        Application.Quit();
    }
}
