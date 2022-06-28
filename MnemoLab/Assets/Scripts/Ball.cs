using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Light _light;
    public Rigidbody _rb;
    public int rebotes;
    public bool pinta;
    private void Start()
    {
        _rb.AddForce(transform.right * 500, ForceMode.Impulse);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!pinta)
        {
            Instantiate(_light, transform.position, Quaternion.identity);
            _rb.AddForce(_rb.velocity.x + 50, _rb.velocity.y + 50, _rb.velocity.z + 50);
            rebotes++;
        }
    }

    private void Update()
    {
        if(rebotes>=15)
        {
            pinta = true;
            _rb.velocity = new Vector3(0, 0, 0);
            rebotes = 0;
            Invoke("ChangeVariable", 30);
        }
    }
    public void ChangeVariable()
    {
        pinta = false;
    }
}
