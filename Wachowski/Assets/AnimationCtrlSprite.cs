using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class AnimationCtrlSprite : MonoBehaviour {

    public string SpriteName = "wach_run_sketch";
    Sprite[] animationSheet;
   public SpriteRenderer render;
    public float Timer;
    public float FrameInterval = .04f;
    // Use this for initialization
    void Start () {
        animationSheet = Resources.LoadAll<Sprite>(SpriteName);
     

    }
	
	


    int frameCn = 0;
    private void FixedUpdate()
    {
        Timer += Time.fixedDeltaTime;
        if(Timer>FrameInterval)
        {
            render.sprite = animationSheet[frameCn];
            frameCn++;
            if (frameCn >= animationSheet.Length)
            {
                frameCn = 0;
            }
            Timer = 0;
        }
      
    }
}
