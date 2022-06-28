using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCat : MonoBehaviour
{

    public int direction = 0;
    public bool activeMovement = false;
   public float velocity = 5;

    void Update()
    {
        if (activeMovement)
        {
            if (direction == 0)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * velocity, Space.World);

            }
            if (direction == 1)
            {
                transform.Translate(Vector3.left * Time.deltaTime * velocity, Space.World);

            }
            if (direction == 2)
            {
                transform.Translate(Vector3.right * Time.deltaTime * velocity, Space.World);

            }
            if (direction == 3)
            {
                transform.Translate(Vector3.back * Time.deltaTime * velocity, Space.World);

            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Stoped"))
        {
            activeMovement = false;
            direction = other.GetComponent<Stopeds>().numberDirection;
        }
        if (other.CompareTag("Continued"))
        {
            activeMovement = true;
            direction = other.GetComponent<Stopeds>().numberDirection;
        }

        if (other.CompareTag("Player"))
        {
            activeMovement = true;
        }
    }
}
