using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityCooldown : MonoBehaviour
{
    public Image abilityIcon;

    public void UseAbility(float cooldown){
        abilityIcon.fillAmount = 1;
        StopCoroutine(CDWait(cooldown));
        StartCoroutine(CDWait(cooldown));
    }

    IEnumerator CDWait(float cooldown){
        yield return new WaitForSeconds(0.1f);
        abilityIcon.fillAmount -= 1/((cooldown-cooldown/9)*10);
        if(abilityIcon.fillAmount > 0){
            StartCoroutine(CDWait(cooldown));
        }
    }

}
