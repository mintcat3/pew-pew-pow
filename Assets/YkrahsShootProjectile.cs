using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YkrahsShootProjectile : MonoBehaviour
{
    public GameObject YkrahsProjectile;
    public float firerate = 1f;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < firerate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            transform.position = new Vector3(5, Random.Range(-3f, 3f), 0);
            Instantiate(YkrahsProjectile, transform.position, transform.rotation);
            transform.position = new Vector3(5, Random.Range(-3f, 3f), 0);
            Instantiate(YkrahsProjectile, transform.position, transform.rotation);
            transform.position = new Vector3(5, Random.Range(-3f, 3f), 0);
            Instantiate(YkrahsProjectile, transform.position, transform.rotation);
            timer = 0;
        }
        
    }
}
