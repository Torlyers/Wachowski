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
        animes = new List<Sprite[]>();

        //render = gameObject.GetComponent<SpriteRenderer>();
        for (int i = 0; i < animeName.Count; i++)
        {            
            var newAnime = Resources.LoadAll<Sprite>(animeName[i]);
            animes.Add(newAnime);
            //animeDic.Add(i, animes[i]);
        }

        curAnime = animes[0];

    }	


    int frameCn = 0;
    private void FixedUpdate()
    {

        //curAnime = animeDic[Player.playerState];
        if (Player.Instance.isLastStateDone)
        {
            switch (Player.Instance.playerState)
            {
                case Player.state.run:
                    FrameInterval = 0.04f;
                    curAnime = animes[0];
                    Player.Instance.isLastStateDone = false;
                    break;
                case Player.state.jump:
                    FrameInterval = 0.1f;
                    curAnime = animes[1];
                    Player.Instance.isLastStateDone = false;
                    break;
                case Player.state.trip:
                    curAnime = animes[2];
                    Player.Instance.isLastStateDone = false;
                    break;
            }
            frameCn = 0;
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
