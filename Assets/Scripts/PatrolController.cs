using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolController : MonoBehaviour
{
	public List<Transform> patrolPoints;
	private int currentPoint;
	private NavMeshAgent _myAgent;

	// Use this for initialization
	void Start ()
	{
		_myAgent = GetComponent<NavMeshAgent>();
		SetDestination();
	}
	
	// Update is called once per frame
	void Update () {
		if (_myAgent.remainingDistance <= _myAgent.stoppingDistance)
		{
			if (patrolPoints.Count > currentPoint+1)
			{
				currentPoint++;
			}
			else
			{
				currentPoint = 0;
			}
			SetDestination();
		}

		
	}

	private void SetDestination()
	{
		_myAgent.SetDestination(patrolPoints[currentPoint].position);
	}
}
