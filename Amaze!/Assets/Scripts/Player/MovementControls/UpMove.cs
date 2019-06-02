﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpMove : MonoBehaviour {

	public SwipePlayer Player;
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Wall")
		{
			Player.canMoveUp = false;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Wall")
		{
			Player.canMoveUp = true;
		}
	}
}