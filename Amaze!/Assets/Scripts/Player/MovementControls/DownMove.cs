using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownMove : MonoBehaviour {

	public Player Player;
	private void OnTriggerStay(Collider other)
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
