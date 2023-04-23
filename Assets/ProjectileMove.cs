using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public float projectileSpeed = 10;
    // Collider2D collision;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * projectileSpeed) * Time.deltaTime;
        
        
        
        GameObject[] Projectiles = GameObject.FindGameObjectsWithTag("YkrahsProjectile");
        foreach(GameObject Projectile in Projectiles)
        {
            if(Projectile.transform.position.x < -30 || Projectile.transform.position.x > 30 || Projectile.transform.position.y > 20 || Projectile.transform.position.y < -20)
            {
                Destroy(Projectile);
            }
            
            // if (collision.gameObject.name == "Player")
                // {
                    // GameObject.Find("Player").GetComponent<playerBossCollision>().playerDamage(10);
                //     Destroy(Projectile);
                // }
            
        //     void OnTriggerEnter2D(Collider2D collision)
        // {
        //     if (collision.gameObject.name == "Player")
        //     {
        //         // GameObject.Find("Player").GetComponent<playerBossCollision>().playerDamage(10);
        //         GameObject[] Projectiles = GameObject.FindGameObjectsWithTag("YkrahsProjectile");
        //         foreach(GameObject Projectile in Projectiles);
        //         {
        //             Destroy(Projectile);
        //         }
        //     }
        // }
            
            
            // void OnTriggerEnter2D(Collider2D collision)
            //     {
            //         if (collision.gameObject.name == "Player")
            //         {
            //         // GameObject.Find("Player").GetComponent<playerBossCollision>().playerDamage(10);
            //         Destroy(Projectile);
            //         }
            //     }
        }

    }
}
