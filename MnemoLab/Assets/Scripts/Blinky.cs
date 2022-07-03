using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinky : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject actual;
    public void ChangeBody(int _number)
    {
        actual.SetActive(false);
        objects[_number].SetActive(true);
        actual = objects[_number];
    }
}
