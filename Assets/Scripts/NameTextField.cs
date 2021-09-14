using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameTextField : MonoBehaviour
{ 
    public System.Action<string> onValueChanged;
    public string NameEntered { get; private set; } 
   
    private void Start()
    {
        onValueChanged.Invoke(NameEntered);
    }


}
