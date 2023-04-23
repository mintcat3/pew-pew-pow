using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YkrahsProjectileCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.name == "Player")
            {
                // GameObject.Find("Player").GetComponent<playerBossCollision>().playerDamage(10);
                GameObject[] Projectiles = GameObject.FindGameObjectsWithTag("YkrahsProjectile");
                foreach(GameObject Projectile in Projectiles)
                {
                    Destroy(Projectile);
                }
            }
        }
    }
}
