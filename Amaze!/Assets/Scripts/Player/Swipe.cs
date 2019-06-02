using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
	private bool tap, swipeLeft, swipeRight, swipeUp, swipeDown;
	private bool isDrag = false;
	private Vector2 startTap, swipePos;
	
	public Vector2 SwipePos
	{
		get { return swipePos; }
	}
	public bool SwipeLeft
	{
		get { return swipeLeft; }
	}
	public bool SwipeRight
	{
		get { return swipeRight; }
	}
	public bool SwipeUp
	{
		get { return swipeUp; }
	}
	public bool SwipeDown
	{
		get { return swipeDown; }
	}


	private void Update()
	{
		tap = swipeLeft = swipeRight = swipeUp = swipeDown = false;

		//Standalone
		if (Input.GetMouseButtonDown(0))
		{
			tap = true;
			isDrag = true;
			startTap = Input.mousePosition;
		}else if (Input.GetMouseButtonUp(0))
		{
			isDrag = false;
			Reset();
		}

		//Mobile
		if (Input.touches.Length > 0)
		{
			if (Input.touches[0].phase == TouchPhase.Began)
			{
				tap = true;
				isDrag = true;
				startTap = Input.touches[0].position;
			}else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
			{
				isDrag = false;
				Reset();
			}
		}
		
		
		//Calculate Pos
		
		swipePos = Vector2.zero;
		if (isDrag)
		{
			if (Input.touches.Length > 0)
			{
				swipePos = Input.touches[0].position - startTap;
			}else if (Input.GetMouseButton(0))
			{
				swipePos = (Vector2) Input.mousePosition - startTap;
			}
		}


		//DeadZone
		if (swipePos.magnitude > 125)
		{
			float x = swipePos.x;
			float y = swipePos.y;

			if (Mathf.Abs(x) > Mathf.Abs(y))
			{
				if (x < 0)
				{
					swipeLeft = true;
				}
				else
				{
					swipeRight = true;
				}
			}
			else
			{
				if (y < 0)
				{
					swipeDown = true;
				}
				else
				{
					swipeUp = true;
				}
			}
			
			Reset();
		}
	}

	private void Reset()
	{
		isDrag = false;
		startTap = swipePos = Vector2.zero;
		
	}
}
