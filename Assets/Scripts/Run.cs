using UnityEngine;
using System.Collections;

public class Run : MonoBehaviour 
{
	public Transform player;
	NavMeshAgent agent;
	GameObject target;
	float x = 0;
	float dist;

	void Start () 
	{
		target = new GameObject();
		agent = GetComponent<NavMeshAgent> ();
		agent.speed = 50;
		agent.acceleration = 50;
	}

	void Update () 
	{
		Vector3 pos = player.transform.GetComponent<Scream> ().target.transform.position;
		target.transform.position = pos;
		dist = Vector3.Distance (transform.position, target.transform.position);
		agent.SetDestination (target.transform.position);
		agent.speed = 50;
		agent.acceleration = 50;
		if(dist < 1) 
		{
			x = x + Time.deltaTime;
			if(x > 3)
			{
				transform.GetComponent<Pathfinder>().enabled = true;
				transform.GetComponent<Pathfinder>().agent.SetDestination(transform.GetComponent<Pathfinder>().target1.position);
				agent.speed = 10;
				agent.acceleration = 10;
				transform.GetComponent<Run>().enabled = false;
				x = 0;
			}
		}
	}
}