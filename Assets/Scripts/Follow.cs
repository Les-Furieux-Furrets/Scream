using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour 
{
	public Transform master;
	Vector3 camPos;
	KeyCode Dezoom = KeyCode.W;
	float x;
	float y;

	void Start () 
	{
		x = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		camPos = master.position;

		//transform.position = camPos;
		if (Input.GetKey (Dezoom)) {
			camPos.y=95;
			camPos.y = Mathf.MoveTowards (camPos.y,300,x);
			x = x+ (Time.deltaTime * 100);
			y = 0;
		} else {
			x=0;
			camPos.y = 95;
		}
		transform.position = camPos;
	}
	}

