using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public static void LoadSceneString(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame(){
        Application.Quit();
    }
}