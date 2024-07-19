using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthStaminaUpdateBar : MonoBehaviour
{
    public Stats stats;
    public ProgressBar health;
    public ProgressBar stamina;
    void Update(){
        health.BarValue = stats.currentHealth / stats.maxHealth * 100;
        stamina.BarValue = stats.stamina / stats.maxStamina * 100;
    }
}
