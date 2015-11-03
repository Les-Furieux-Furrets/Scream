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
		camPos = master.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		camPos.x = master.position.x;
		camPos.z = master.position.z;
		rezoom ();
		//transform.position = camPos;
		if (Input.GetKey (Dezoom)) {
			camPos.y = Mathf.MoveTowards (camPos.y,300,x);
			x = x+ (Time.deltaTime * 30);
			y = 0;
		} else {
			x=0;
					}
		transform.position = camPos;
	}

	public void rezoom() {

		if (camPos.y <= 95) {
			camPos.y = 95;
		} else {
			camPos.y = Mathf.MoveTowards (camPos.y,95,y);
			y = y+ (Time.deltaTime * 13);
		}
	}
}

