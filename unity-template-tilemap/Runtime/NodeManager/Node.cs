using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour, IComponent
{
	public string[] attributes; //
	public int layer;

	//public void Create(int x, int y) => this.Invoke(new NodeCreated { x = x, y = y });
	//public void Delete(int x, int y) => this.Invoke(new NodeDeleted { x = x, y = y });
}
