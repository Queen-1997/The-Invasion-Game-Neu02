using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToGameScene()
    {
     SceneManager.LoadScene("Main");
    }

    public void Exit(){
        Application.Quit();
    }

    void Update(){
        
    }
}
