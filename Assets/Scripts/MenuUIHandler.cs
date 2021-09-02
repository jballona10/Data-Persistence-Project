using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
     * StartNew
     * 
     * Starts the main scene when the start button is presssed
     */
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    /*
     * Quit
     * 
     * Exits the game when the quit button is pressed
     */
    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif 
    }
}
