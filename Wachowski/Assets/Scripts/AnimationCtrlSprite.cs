using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class AnimationCtrlSprite : MonoBehaviour {


    public List<string> animeName;
    public List<Sprite[]> animes;

    //private Dictionary<int, Sprite[]> animeDic;
    public string SpriteName = "wach_run_sketch";

    Sprite[] curAnime;
    public SpriteRenderer render;
    public float Timer;
    public float FrameInterval = .04f;


    // Use this for initialization
    void Start ()
    {
        //render = gameObject.GetComponent<SpriteRenderer>();
        for(int i = 0; i < animeName.Count; i++)
        {
            animes[i] = Resources.LoadAll<Sprite>(SpriteName);
            //animeDic.Add(i, animes[i]);
        }

    }
	
	


    int frameCn = 0;
    private void FixedUpdate()
    {

        //curAnime = animeDic[Player.playerState];
        switch(Player.Instance.playerState)
        {
            case Player.state.run:
                curAnime = animes[0];
                break;
            case Player.state.jump:
                curAnime = animes[1];
                break;
            case Player.state.trip:
                curAnime = animes[2];
                break;
        }

        Timer += Time.fixedDeltaTime;
        if(Timer >= FrameInterval)
        {
            
            render.sprite = curAnime[frameCn];
            frameCn++;
            if (frameCn >= curAnime.Length)
            {
                frameCn = 0;
            }
            Timer = 0;
        }
      
    }
}
