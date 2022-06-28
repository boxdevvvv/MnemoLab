using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class ActivatePaint : MonoBehaviour
{
    public ParticleSystem paint;
    //   public GameObject Luz;
    private Quaternion rotationn;



    private void Start()
    {
        rotationn = transform.rotation;

    }
    public Transform player;
    private void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetMouseButtonDown(0)) 
        {
            paint.Play();
            SpawnBox();
            Invoke("CancelAnim",0.3f);
            Debug.Log("trigger");
        }
    }
    public Transform box;
    public Transform directionCamera;
    public void SpawnBox()
    {
       // Transform _box  =  Instantiate(box, transform.position, rotationn);
      //  Instantiate(box, transform.position,  player.transform.rotation);

        // _box.transform.parent = directionCamera.transform;
        print("Spawneo cuadrado");
    }
    public void CancelAnim()
    {
        paint.Stop();
    }


    public void Pintura()
    {

        paint.Play();
        SpawnBox();
        Invoke("CancelAnim", 0.3f);
        Debug.Log("trigger");
    }




}
