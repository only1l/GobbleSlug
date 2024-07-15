using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
   public static void LoadScene(){
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        int sceneCount = SceneManager.sceneCount;
        int nextSceneIndex =(sceneIndex ) % sceneCount;
        SceneManager.LoadScene(nextSceneIndex);
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(nextSceneIndex));
    }

    public void LoadSceneString(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
