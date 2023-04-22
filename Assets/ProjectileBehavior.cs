using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    private float time = 0.0f;
    public float timeInBetweenShots;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= timeInBetweenShots)
        {
            time = 0.0f;
            //Trigger the action
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
        }
    }
}
