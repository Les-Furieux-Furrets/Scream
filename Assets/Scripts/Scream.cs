using UnityEngine;
using System.Collections;

public class Scream : MonoBehaviour 
{
	RaycastHit hit;
	int i;
	public KeyCode Space = KeyCode.Space;
	public GameObject target;

	void Start()
	{
		target = new GameObject ();
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		for (i = 0; i < 360; i++) 
		{
			if (Physics.Raycast (transform.position, Quaternion.AngleAxis (i, Vector3.up) * Vector3.right, out hit, 15f)) 
			{
				Gizmos.DrawLine (transform.position, hit.point);
			}
		}
	}

	void Update()
	{
		if(Input.GetKey(Space))
		{
			for (i = 0; i < 360; i++) 
			{
				if (Physics.Raycast (transform.position, Quaternion.AngleAxis (i, Vector3.up) * Vector3.right, out hit, 15f)) 
				{
					if(hit.transform.tag == "person")
					{
						hit.transform.GetComponent<Pathfinder>().enabled = false;
						hit.transform.GetComponent<Run>().enabled = true;
						target.transform.position = hit.transform.position + ((hit.transform.position - transform.position).normalized * 100);
					}
				}
			}
		}
	}
}