using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrahsFacingDirection : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Direction = GameObject.Find("Player").transform.position.x - gameObject.transform.position.x;
        if (Direction < 0)
        {
            gameObject.transform.localScale = new Vector3(-5, 5, 0);
        }
        if (Direction > 0)
        {
            gameObject.transform.localScale = new Vector3(5, 5, 0);
        }
    }
}
