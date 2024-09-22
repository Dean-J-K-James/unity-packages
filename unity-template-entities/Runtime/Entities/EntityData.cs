/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;


//Replace the id and tickCreated variables by putting them in the dictionary.
public class EntityData//<T> for nodes and units
{
	static int staticId; //

	//public readonly T entity;
	public readonly string id;
	public readonly int tickCreated; //put this in the below dictionary.

	public Dictionary<string, object> variables = new Dictionary<string, object>();

	public EntityData()
	{
		//this.entity = entity;
		id = ++staticId + "";
		tickCreated = TickManager.INSTANCE.tick;
	}

	public T GetVar<T>(string varName, T def)
	{
		if (variables.ContainsKey(varName) == false)
		{
			variables[varName] = def;
			return def;
		}

		object value = variables[varName];

		return (T)value;
	}

	public void SetVar<T>(string varName, T val)
	{
		variables[varName] = val;
	}
}