using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour, IComponent, ICreated<PrefData>
{
    public float maxHealth; //
    public float health; //

    public void ChangeHealth(float change)
    {
        health += change;
        //Trigger local OnChanged event.
        //Player listens to this to trigger the global OnChanged.
        this.InvokeChanged();
    }

    //remove the need for this by having health be the inverse. 0 is full health, and maxHealth is death.
    //have max health loaded from JSON and health be a public property.
    public void OnCreated(PrefData pd)
    {
        maxHealth = health;
    }
}
