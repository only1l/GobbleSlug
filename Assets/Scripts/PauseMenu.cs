using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool IsOpened;
    public GameObject pauseMenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(IsOpened){
                Resume();
            }

            else{
                Pause();
            }
        }
    }

    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        IsOpened = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        IsOpened = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadMenu(){
        Time.timeScale = 1f;
        Debug.Log("OCHKO");
        SceneManager.LoadScene("Menu");
    }
    
    public void Restart(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }
}
