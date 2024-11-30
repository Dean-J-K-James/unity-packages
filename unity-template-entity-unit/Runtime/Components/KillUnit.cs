using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillUnit : MonoBehaviour, IComponent, IUnitDie
{
    /**
     * 
     */
    public void OnUnitDie()
    {
        Destroy(gameObject);
    }
}
