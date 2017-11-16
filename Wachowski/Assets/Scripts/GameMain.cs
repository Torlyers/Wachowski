using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain : MonoBehaviour {

    public Player player;
    public Player shadow;

    public List<AudioClip> sfx;

    public static GameMain Instance;
    public  int score;

    private void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
