using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class LightPoint : MonoBehaviour
{
    [SerializeField] private float timeToDie = 30f;
    void Start()
    {
        GetComponent<Light>().DOIntensity(0, timeToDie);
    }
 
}
