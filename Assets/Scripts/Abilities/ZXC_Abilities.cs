using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ZXC_Abilities : MonoBehaviour
{
    public Stats stats;
    public UnityEvent Z_Event;
    public UnityEvent X_Event;
    public UnityEvent C_Event;
    public bool Z_cooldownReady = true;
    public bool X_cooldownReady = true;
    public bool C_cooldownReady = true;
    public AbilityCooldown Z_icon;
    public AbilityCooldown X_icon;
    public AbilityCooldown C_icon;

    void Update(){
        if(PlayerInfo.counter_Z > 0 && Input.GetKeyDown(KeyCode.Z) && Z_cooldownReady){
            Z_cooldownReady = false;    
            StartCoroutine(CooldownWait(stats.Z_Cooldown, Z_cooldownReady));
            Z_Event.Invoke();
            Z_icon.UseAbility(stats.Z_Cooldown);

        }
        if(PlayerInfo.counter_X > 0 && Input.GetKeyDown(KeyCode.X) && X_cooldownReady){
            X_cooldownReady = false; 
            StartCoroutine(CooldownWait(stats.X_Cooldown, X_cooldownReady));
            X_Event.Invoke();
            X_icon.UseAbility(stats.X_Cooldown);
        }
        if(PlayerInfo.counter_C > 0 && Input.GetKeyDown(KeyCode.C) && C_cooldownReady){
            C_cooldownReady = false; 
            StartCoroutine(CooldownWait(stats.C_Cooldown, C_cooldownReady));
            C_Event.Invoke();
            C_icon.UseAbility(stats.C_Cooldown);
        }
    }

    IEnumerator CooldownWait(float cooldown, bool cdReady){
        yield return new WaitForSeconds(cooldown);
        if(cdReady == Z_cooldownReady) Z_cooldownReady = true;
        else if(cdReady == X_cooldownReady) X_cooldownReady = true;
        else if(cdReady == C_cooldownReady) C_cooldownReady = true;
    }
}
