/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 */
public class UnitUpdater : MonoBehaviour
{
    void Update()
    {
        var us = GetComponentsInChildren<Unit>();

        foreach (var u in us)
        {
            u.InvokeUpdated(u.unitData);
        }
    }
}
