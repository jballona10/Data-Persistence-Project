using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;
using System;

#if UNITY_EDITOR
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{
    // text field for player name
    public InputField playerName;

    /*
     * NameEntered
     * 
     * Parameters:
     *  - name: player name entered
     *  
     *  Sets the players name for this instance
     */
    public void NameEntered(string name)
    {
        Player.Instance.playerName = name;
    }

    // Start is called before the first frame update
    void Start()
    {
        // if the player name is not empty, call NameEntered
        if (playerName != null)
        {
            playerName.onValueChanged.AddListener(delegate { NameEntered(playerName.text); });
        }
        // else leave the name blank
        else
        {
            Player.Instance.playerName = "";
        }

        
    }

    private void Update()
    {

    }

    /*
     * StartNew
     * 
     * Starts the main scene when the start button is presssed
     */
    public void StartNew()
    {
        //NameEntered(playerName.text);
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
