using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinky : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject actual;
   public void ChangeBody(int _collision)
   {
        actual.SetActive(false);
        objects[_collision].SetActive(true);
       actual = objects[_collision];

    }
}
