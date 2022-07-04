using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToOtherScene : MonoBehaviour
{
    void Start()
    {
        Invoke("ChangeScene", 5);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }


}
