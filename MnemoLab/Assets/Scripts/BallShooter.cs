using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooter : MonoBehaviour
{

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;

    [SerializeField] private float launchForce = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        GameObject ball = Instantiate(bullet, firePoint.position, firePoint.rotation);

        ball.GetComponent<Rigidbody>().velocity = firePoint.forward * launchForce;
    }
}
