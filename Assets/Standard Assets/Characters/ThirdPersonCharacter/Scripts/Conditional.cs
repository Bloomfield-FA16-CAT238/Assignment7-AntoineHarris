using UnityEngine;
using System.Collections;

public class Conditional : MonoBehaviour 
{
	public int score;
	public bool CheckPoint;

	void Update()
	{
		if (score == 50 && CheckPoint) 
		{
			Debug.Log ("Score is 50");
		}

		else if (score == 40 && !CheckPoint) 
		{
			Debug.Log ("Score is 40");
		}

		else
		{
			Debug.Log ("Score is 0");
		}
	}
}
