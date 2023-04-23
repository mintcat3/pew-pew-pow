using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerBossCollision : MonoBehaviour
{
    public GameObject healthBar;
    public GameObject healthBarBorder;
    public float startingHealth = 100;
    public float playerHealth;
    public Text pHealthText;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = startingHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        pHealthText.text = ("Player Health: " + playerHealth.ToString());
        if (playerHealth <= 0)
        {
            SceneManager.LoadScene("Level Selection Menu");
        }

    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="krahs")
        {

            // GameObject.Find("krahs").GetComponent<KrahsHealth>().TakeDamage(1);
            // GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
            // foreach(GameObject bullet in bullets)
            // {
            //         // GameObject.Find("krahs").GetComponent<KrahsHealth>().TakeDamage(1);
            //         Destroy(bullet);
                
            // }
            playerDamage(10);

        }
    }

    public void playerDamage(float x)
    {
        playerHealth -= x;
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.DamageTaken);

    }

}
