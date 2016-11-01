using UnityEngine;
using System.Collections;

public class TriggerEvent : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) 
		{
			Debug.Log("Hello!");
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag ("Player")) 
		{
			Debug.Log ("Goodbye");
		}
	}
}
