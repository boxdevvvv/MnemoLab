using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TuboLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(lighting());
    }
    public Light luz;
    private bool activate = true;
    IEnumerator lighting()
    {
        while (activate)
        {
         //   luz.gameObject.SetActive(false);
             luz.DOIntensity(0, 5);
            yield return new WaitForSeconds(0.05f);
            luz.DOIntensity(5, 0.5f);
            luz.gameObject.SetActive(true);

            yield return new WaitForSeconds(0.05f);
           // luz.gameObject.SetActive(false);
             luz.DOIntensity(0, 5);
            yield return new WaitForSeconds(0.05f);
            luz.DOIntensity(5, 0.5f);
            luz.gameObject.SetActive(true);
            luz.DOIntensity(0, 5);
            yield return new WaitForSeconds(0.05f);
            luz.DOIntensity(5, 0.5f);
            luz.gameObject.SetActive(true);

            yield return new WaitForSeconds(0.05f);
            //luz.gameObject.SetActive(false);
            luz.DOIntensity(0, 5);
            yield return new WaitForSeconds(0.05f);
            luz.DOIntensity(5, 0.5f);
            luz.gameObject.SetActive(true);

            luz.DOIntensity(0, .5f);
            luz.intensity = 0;
            //luz.gameObject.SetActive(false);
            yield return new WaitForSeconds(.2f);
            luz.gameObject.SetActive(true);
            //luz.intensity = 10;
            luz.DOIntensity(3, 1);
            yield return new WaitForSeconds(3);


        }

        yield break;
    }
}
