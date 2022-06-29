using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPoint : MonoBehaviour
{
    [SerializeField] private float timeToDie = 15f;
    void Start()
    {
        Destroy(gameObject, timeToDie);
    }
 
}
