using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ZXC_Abilities : MonoBehaviour
{
    public UnityEvent Z_Event;
    public UnityEvent X_Event;
    public UnityEvent C_Event;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Z)){
            Z_Event.Invoke();
        }
        if(Input.GetKeyDown(KeyCode.X)){
            X_Event.Invoke();
        }
        if(Input.GetKeyDown(KeyCode.C)){
            C_Event.Invoke();
        }
    }
}
