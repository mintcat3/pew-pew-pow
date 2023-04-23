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
    
    
    void Start()
    {
        gameObject.GetComponent<ParticleSystem>().Stop();
    }
    
    public void TakeDamage(int Damage)
    {
        health -= Damage; 
        
        if (health <= (1/4) * health)
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
        TakeDamage(1);
    }
}
