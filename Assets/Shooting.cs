using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire;
    private float timer;
    public float timeBetweenFiring;
    public float time;

    //Shooting.cs is slightly modified from https://www.youtube.com/watch?v=-bkmPm_Besk

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;
        if (!PlayerMovement.flipped)
        {
            float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotZ);
        }
        else
        {
            float rotZ = Mathf.Atan2(-rotation.y, -rotation.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotZ);
        }

        if(!canFire)
        {
            timer += Time.deltaTime;
            if(timer > timeBetweenFiring)
            {
                canFire = true;
                timer = 0;
            }
        }

        if(Input.GetMouseButton(0) && canFire)
        {
            canFire = false;
            GameObject bulletSpawn = Instantiate(bullet, bulletTransform.position, Quaternion.identity);

        }

        GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
        foreach(GameObject bullet in bullets)
        {
            if(bullet.transform.position.x < -30 || bullet.transform.position.x > 30 || bullet.transform.position.y > 20 || bullet.transform.position.y < -20)
            {
                Destroy(bullet);
            }
        }
    }
}
