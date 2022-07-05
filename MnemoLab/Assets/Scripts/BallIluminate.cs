using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallIluminate : MonoBehaviour
{
    public Light _light;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Instantiate(_light, transform.position, Quaternion.identity);
           Destroy(gameObject);

        }
    }
}
