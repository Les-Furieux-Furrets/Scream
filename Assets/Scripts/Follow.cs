using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour 
{
	public Transform master;
	Vector3 camPos;

	void Start () 
	{
	
	}
	
	void Update () 
	{
		camPos = master.position;
		camPos.y = 95;
		transform.position = camPos;
	}
}
