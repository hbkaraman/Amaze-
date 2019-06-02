using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownMove : MonoBehaviour {

	public SwipePlayer Player;
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Wall")
		{
			Player.canMoveDown = false;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Wall")
		{
			Player.canMoveDown = true;
		}
	}
}
