using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToHealth : MonoBehaviour
{
    public SpriteRenderer sprite;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            HealthBar.instance.AddHealth();
            Destroy(gameObject);
        }
    }
}
