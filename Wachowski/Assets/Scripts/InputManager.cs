using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    public static InputManager Instance;

    public Player player;
    public Shadow shadow;

    private void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.jump();
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            shadow.jump();
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            player.changeDir();
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            shadow.changeDir();
        }
	}
}
