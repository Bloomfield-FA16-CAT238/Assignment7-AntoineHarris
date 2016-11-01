using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {
	public GameController gamecontroller;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider other) 
	{
		gamecontroller.Collect();
		Destroy(this.gameObject); 
	}
}

