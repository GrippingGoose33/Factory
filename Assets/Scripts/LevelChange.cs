using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    public void LevelChanger(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);//Llamar a la escena nombrada
    }
}
