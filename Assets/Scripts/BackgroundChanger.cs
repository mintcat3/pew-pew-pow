using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite bg1;
    public Sprite bg2;
    public Sprite bg3;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        ChangeSprite();
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetMouseButtonDown(0))
        // {
        //     ChangeSprite();
        // }
    }
    
    void ChangeSprite()
    {
        if (takesCareOfLevelIDK.buttonPressed == 1)
        {
            spriteRenderer.sprite = bg1;
        }
        if (takesCareOfLevelIDK.buttonPressed == 2)
        {
            spriteRenderer.sprite = bg2;
        }
        if (takesCareOfLevelIDK.buttonPressed == 3)
        {
            spriteRenderer.sprite = bg3;
        }
    }

}
