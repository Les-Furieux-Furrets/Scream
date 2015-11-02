using UnityEngine;
using System.Collections;

public class Scream : MonoBehaviour 
{
	RaycastHit hit;
	int i;

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		for (i = 0; i < 360; i++) 
		{
			if (Physics.Raycast (transform.position, Quaternion.AngleAxis (i, Vector3.up) * Vector3.right, out hit, 200f)) 
			{
				Gizmos.DrawLine (transform.position, hit.point);
				if(hit.transform.tag == "person")
				{
					hit.transform.GetComponent<NavMeshAgent>().enabled = false;
					hit.transform.GetComponent<Pathfinder>().enabled = false;
//					hit.transform.GetComponent<Run>().enabled = true;
				}
			}
		}
	}
}
