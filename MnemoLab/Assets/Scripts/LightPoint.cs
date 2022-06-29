using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPoint : MonoBehaviour
{
    [SerializeField] private float timeToDie = 30f;
    void Start()
    {
        Destroy(gameObject, timeToDie);
    }
 
}
