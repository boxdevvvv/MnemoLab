using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CatController : MonoBehaviour
{
    public Vector3[] ubication;
    public Quaternion[] _rotation;
    public int colisions;
    public ParticleSystem[] particulas;
    public bool meToquetiaron;

    #region Boleanas que te detecta el gato
    public bool isBlinky;
    public bool isMnemo;
    public bool isClyde;
    public bool isPinky;
    public bool isInky;
    #endregion


    #region detector de colision de bola con gato
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball") && !meToquetiaron)
        {
            colisions++;
            ChangePosition();
            if (isBlinky) //toma el scripot blinky
            {
              GetComponent<Blinky>().ChangeBody(colisions);
            }
            if (isMnemo)
            {
                GetComponent<MovementCat>().ChangeDirection();
            }

        }

    }
    #endregion

    #region cambiador de posicion
    public void ChangePosition()
    {
        if (colisions <= 2)
        {
            meToquetiaron = true;
            particulas[colisions].transform.parent = null;
            particulas[colisions].Play();
            Invoke("StopParticle", 1.9f);
            GetComponent<AudioSource>().PlayOneShot(capturado);
            transform.position = ubication[colisions];
            transform.rotation = _rotation[colisions];

            print("colisiones = " + colisions);
        }
        else
        {
            ChageStatus();
        }

    }

    public void StopParticle()
    {
        meToquetiaron = false;
        particulas[colisions].Stop();
    }
    //public ParticleSystem particleEffect;
    //SOLO PONER CUANDO ESTE INTEGRADO LAS PARTICULAS
    public AudioClip capturado;
    public void ChageStatus()
    {
        particulas[colisions].transform.parent = null;
        particulas[colisions].Play();
        GetComponent<AudioSource>().PlayOneShot(capturado);
        GameManager._gameManager.catCatch++;
        GameManager._gameManager.Win();
        Invoke("StopParticle", 1.9f);

        gameObject.SetActive(false);

        Debug.LogWarning("Se desactiovo");
        // particleEffect.Play();
    }
    #endregion

    #region sonidos
    public AudioClip[] catSounds;
    public float tiempoSounds;
    private void Start()
    {
        Invoke("SoundEffect", tiempoSounds);
    }


    public void SoundEffect()
    {
       GetComponent<AudioSource>().PlayOneShot(catSounds[Random.Range(0,3)]);
        Invoke("SoundEffect", tiempoSounds);

    }

    #endregion
    private void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
