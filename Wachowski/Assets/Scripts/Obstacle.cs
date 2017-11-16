using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    Player player;
    Player shadow;

	void Start ()
    {
        player = GameMain.Instance.player;
        shadow = GameMain.Instance.shadow;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player.decelerate();
            player.switchState(Player.state.trip);
        }
        else if(other.gameObject.tag == "Shadow")
        {
            shadow.decelerate();
            shadow.switchState(Player.state.trip);
        }
    }

    private void OnTriggerExit(Collider other)
    {

        AudioSource.PlayClipAtPoint(GameMain.Instance.sfx[2], Vector3.zero);

        if (other.gameObject.tag == "Player")
        {
            player.accelerate();
            if(player.isOnGround)
                player.switchState(Player.state.run);
        }
        else if (other.gameObject.tag == "Shadow")
        {
            shadow.accelerate();
            if(shadow.isOnGround)
                shadow.switchState(Player.state.run);
        }
    }
}
