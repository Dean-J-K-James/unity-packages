/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

//
public interface IUseItem { void OnUseItem(Unit s); }
public interface IFireWpn { void OnFireWpn(Unit s, Unit t); }
public interface IFndTrgt { void OnFireWpn(Unit s, Unit t); }

//IUseItem
//Lets say one of our item slots has a health potion that automatically gets used when health is below 50%. Or the item gets used when the player presses the key. This triggers that.
//Press 1 to use the item in slot 1.
//If the item in slot 1 is a weapon, equip that weapon.
//This then causes a problem of IUseItem does two things: equip and target.

//Also, what about a mine layong weapon.
//Needs a source, but no target.
//That would trigger on IUseItem.
//Rename IFireWpn to IFndTrgt... (I Found Target)