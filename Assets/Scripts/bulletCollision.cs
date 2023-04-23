using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="krahs")
        {
            GameObject.Find("krahs").GetComponent<KrahsHealth>().TakeDamage(2);
            GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
            foreach(GameObject bullet in bullets)
            {
                    // GameObject.Find("krahs").GetComponent<KrahsHealth>().TakeDamage(1);
                    Destroy(bullet);
                
            }
        }
    }
}
