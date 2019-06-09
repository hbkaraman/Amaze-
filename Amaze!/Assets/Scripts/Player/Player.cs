using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	public Swipe swipeCont;
	private Vector3 desiredPos = Vector3.zero;
	public float speed ;
	private Rigidbody rb;

	private bool canMove = true;
	public bool canMoveRight;
	public bool canMoveLeft;
	public bool canMoveUp;
	public bool canMoveDown;

	private void Start()
	{
		desiredPos = transform.position;
		rb = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		Movement(desiredPos);		
		Animate();
	}
	private void Update()
	{
	
		if (canMove)
		{
			if (swipeCont.SwipeLeft && canMoveLeft)
			{
				desiredPos = Vector3.left;
				canMove = false;
			}
			else if (swipeCont.SwipeRight && canMoveRight)
			{
				desiredPos = Vector3.right;
				canMove = false;
			}
			else if (swipeCont.SwipeUp && canMoveUp)
			{
				desiredPos = Vector3.forward;
				canMove = false;
			}
			else if (swipeCont.SwipeDown && canMoveDown)
			{
				desiredPos = Vector3.back;
				canMove = false;
			}
		}
	}
		
	void Animate()
	{
		
	}
	
	void Movement(Vector3 direction)
	{
		rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Wall")
		{
			if (canMove)
			{
				desiredPos = Vector3.zero;
			}
			//transform.position = transform.localPosition;
			canMove = true;
		}
	}

	private void OnCollisionStay(Collision other)
	{
		if (other.gameObject.tag == "Wall")
		{
			canMove = true;
		}
	}
}
