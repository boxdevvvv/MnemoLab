using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooter : MonoBehaviour
{

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;

    [SerializeField] private float launchForce = 2;

    public AudioClip shot;
    public GameObject particle;
    public void Update()
    {
        if(Input.GetKeyDown("z"))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        GameObject ball = Instantiate(bullet, firePoint.position, firePoint.rotation);
        ball.GetComponent<Rigidbody>().velocity = firePoint.forward * launchForce;
        Instantiate(particle, firePoint.position, firePoint.rotation);
        GetComponent<AudioSource>().PlayOneShot(shot);
    }
}
