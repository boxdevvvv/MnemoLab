using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int catCatch;
    public static GameManager _gameManager;
    private void Awake()
    {
        _gameManager = this;
    }
   public void Win()
    {
        if(catCatch >=4)
        {
            SceneManager.LoadScene(2);
        }
    }
}
