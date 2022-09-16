using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AbilityUI : MonoBehaviour
{
    [Header("UI")]
    public TMP_Text abilityName;
    public TMP_Text abilityCooldownText;

    [Header("Components")]
    public AbilityHolder abilityHolder;

    private void Awake()
    {
        abilityHolder = GameObject.FindGameObjectWithTag("Player").GetComponent<AbilityHolder>();
    }

    private void Update()
    {
        HandleAbilityCooldown();
        HandleAbilityName();
    }
    public void HandleAbilityName()
    {
        if (abilityHolder.currentAbility == null)
        {
            abilityName.text = "Reach 10 Pts";
        }
        else
        {
            abilityName.text = abilityHolder.currentAbility.abilityName;
        }
    }

    public void HandleAbilityCooldown()
    {
        if (abilityHolder.currentAbility == null)
        {
            abilityCooldownText.text = "No Ability";
        }
        else if (abilityHolder.currentCooldown == 0)
        {
            abilityCooldownText.text = "Ready";
        }
        else
        {
            abilityCooldownText.text = abilityHolder.currentCooldown.ToString();
        }
    }
    
}
