using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipePlayer : MonoBehaviour
{
	public Swipe swipeCont;
	public Transform Player;
	private Vector3 desiredPos;


	private void Start()
	{
		desiredPos = Player.transform.position;
	}

	private void Update()
	{
		if (swipeCont.SwipeLeft)
			desiredPos += Vector3.left;
		if(swipeCont.SwipeRight)
			desiredPos += Vector3.right;
		if (swipeCont.SwipeUp)
			desiredPos += Vector3.forward;
		if(swipeCont.SwipeDown)
			desiredPos += Vector3.back;

		Player.transform.position = Vector3.MoveTowards(Player.transform.position, desiredPos, 3f * Time.deltaTime);
	}
}
