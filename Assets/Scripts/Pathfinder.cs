using UnityEngine;
using System.Collections;

public class Pathfinder : MonoBehaviour {

	public Transform target1;
	public Transform target2;
	public Transform target3;
	public Transform target4;
	float dist1;
	float dist2;
	float dist3;
	float dist4;
	public NavMeshAgent agent;

	void Start () 
	{
		agent = GetComponent<NavMeshAgent> ();
		agent.SetDestination(target1.position);
	}
	
	void Update () 
	{
		dist1 = Vector3.Distance (transform.position, target1.position);
		dist2 = Vector3.Distance (transform.position, target2.position);
		dist3 = Vector3.Distance (transform.position, target3.position);
		dist4 = Vector3.Distance (transform.position, target4.position);
		if (dist1 < 2) 
		{
			agent.SetDestination (target2.position);
		}
		if (dist2 < 2) 
		{
			agent.SetDestination (target3.position);
		}
		if (dist3 < 2) 
		{
			agent.SetDestination (target4.position);
		}
		if (dist4 < 2) 
		{
			agent.SetDestination (target1.position);
		}
	}
}