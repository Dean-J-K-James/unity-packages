using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrantXP : MonoBehaviour, IComponent, IUnitDie
{
    public int xp;

    /**
     * 
     */
    public void OnUnitDie()
    {
        Player.INSTANCE.AddXP(xp);
    }
}
