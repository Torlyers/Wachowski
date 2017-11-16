using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    public static InputManager Instance;

    Player player;
    Player shadow;

    private void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start ()
    {
        player = GameMain.Instance.player;
        shadow = GameMain.Instance.shadow;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //touchscreen ctrl
        if(Input.touchCount > 0)
        {

            foreach(Touch touch in Input.touches)
            {
                if (touch.position.y < Screen.height / 2)
                    player.jump();
                else
                    shadow.jump();
            }

        }


        //keyborad ctrl
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
            AudioSource.PlayClipAtPoint(GameMain.Instance.sfx[0], Vector3.zero);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            shadow.changeDir();
            AudioSource.PlayClipAtPoint(GameMain.Instance.sfx[1], Vector3.zero);

        }
    }
}
