using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightingSpawner : MonoBehaviour
{
    public GameObject lighting;
    public int force = 1;

    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
    }
    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(lighting, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z-1), Quaternion.identity);
        Destroy(gameObject);
    }
}
