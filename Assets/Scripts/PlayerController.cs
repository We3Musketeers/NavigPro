using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Experimental.UIElements;

public class PlayerController : MonoBehaviour
{
	private NavMeshAgent _myAgent;

	void Awake ()
	{

	}

	// Use this for initialization
	void Start ()
	{
		_myAgent = GetComponent<NavMeshAgent>();	    
	}

	void FixedUpdate ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(MouseButton.LeftMouse.GetHashCode()))
		{
			Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(mouseRay, out hit))
			{
				_myAgent.SetDestination(hit.point);
			}
		}
	}
}
