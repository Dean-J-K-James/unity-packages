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

    public void OnCreated(PrefData pd)
    {
        maxHealth = health;
    }
}
