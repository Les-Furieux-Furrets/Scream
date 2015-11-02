using UnityEngine;
using System.Collections;

public class Simple2DMoveController : MonoBehaviour {

	public KeyCode Left = KeyCode.LeftArrow;
	public KeyCode Right = KeyCode.RightArrow;
	public KeyCode Up = KeyCode.UpArrow;
	public KeyCode Down = KeyCode.DownArrow;

	float normalSpeed = 20;
	float slowSpeed = 1.5f;
	float currentSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
   		Vector3 pos = transform.localPosition;
		if (Input.GetKey (KeyCode.LeftShift)) 
		{
			currentSpeed = slowSpeed;
		} 
		else 
		{
			currentSpeed = normalSpeed;
		}
		if(Input.GetKey(Left)) pos -= transform.right * currentSpeed * Time.deltaTime;
		if(Input.GetKey(Right)) pos += transform.right * currentSpeed * Time.deltaTime;
		if(Input.GetKey(Down)) pos -= transform.forward * currentSpeed * Time.deltaTime;
		if(Input.GetKey(Up)) pos += transform.forward * currentSpeed * Time.deltaTime;
    	transform.localPosition = pos;
	}
}