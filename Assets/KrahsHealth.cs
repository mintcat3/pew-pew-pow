using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrahsHealth : MonoBehaviour
{ 
    public int health = 100;
    private float time = 0f;
    private float timeDeath = 0f;
    public float timeBeforeDeath2 = 5f;
    // Start is called before the first frame update

    public void TakeDamage(int Damage)
    {
        health -= Damage; 
        
        if (health <= 25) //25% of the boss health
        {
            GetComponent<Animator>().SetBool("isEnraged", true);
        }

        if (health <= 0)
        {
            GetComponent<Animator>().SetBool("isDead", true);
            gameObject.transform.localScale = new Vector3(5, -5, 0);
            if (timeDeath >= timeBeforeDeath2) 
            {
                timeDeath = 0f;
                Destroy(gameObject);
            }
           
        }
    }
    void Update()
    {
        if (health <= 0)
        {
             timeDeath += Time.deltaTime;
        }
        if (health >= 25)
        {
            TakeDamage(1);
        }
    }
}
