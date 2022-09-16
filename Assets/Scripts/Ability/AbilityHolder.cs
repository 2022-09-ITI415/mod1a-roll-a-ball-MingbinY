using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHolder : MonoBehaviour
{
    public Ability currentAbility;

    [SerializeField]float cooldown;
    float activeTimer;
    public float currentCooldown;
    enum AbilityState
    {
        Ready,
        Active,
        Cooldown
    }

    [SerializeField]AbilityState currentState;

    private void Start()
    {
        currentState = AbilityState.Ready;
    }

    private void Update()
    {
        if (currentAbility != null)
        {
            UpdateAbilityState();
        }
    }

    public void OnAbility()
    {
        if (currentAbility != null)
        {
            ActivateAbility();
        }
    }

    void UpdateAbilityState()
    {
        if (currentAbility != null)
        {
            cooldown = currentAbility.cooldown;
        }

        currentCooldown = cooldown - (Time.time - activeTimer);
        if (currentCooldown < 0)
        {
            currentCooldown = 0;
        }
        if (currentState == AbilityState.Ready)
        {
            return;
        }
        else if (currentState == AbilityState.Active)
        {
            if (Time.time - activeTimer > currentAbility.duration)
            {
                //Enter cooldown
                currentState = AbilityState.Cooldown;
            }
        }
        else if (currentState == AbilityState.Cooldown)
        {
            if (Time.time - activeTimer > currentAbility.cooldown)
            {
                //Ability ready
                currentState = AbilityState.Ready;
            }
        }
    }
    public void ActivateAbility()
    {
        Debug.Log("Active");
        if (currentState == AbilityState.Ready)
        {
            //Active ability
            currentAbility.Activate(gameObject);
            activeTimer = Time.time;
            currentState = AbilityState.Active;
        }
    }
}
