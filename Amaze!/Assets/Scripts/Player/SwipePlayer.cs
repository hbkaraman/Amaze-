using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipePlayer : MonoBehaviour
{
	public Swipe swipeCont;
	
	private Vector3 desiredPos = Vector3.zero;
	private Vector3 nextDirection = Vector3.zero;

	private float speed = 30f;
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
		Debug.Log(desiredPos);
		Debug.Log(canMove);
		Debug.Log(canMoveRight);

		if (canMove)
		{
			if (swipeCont.SwipeLeft && canMoveLeft)
			{
				desiredPos += Vector3.left;
				canMove = false;
			}

			if (swipeCont.SwipeRight && canMoveRight)
			{
				desiredPos += Vector3.right;
				canMove = false;
			}

			if (swipeCont.SwipeUp && canMoveUp)
			{
				desiredPos += Vector3.forward;
				canMove = false;
			}

			if (swipeCont.SwipeDown && canMoveDown)
			{
				desiredPos += Vector3.back;
				canMove = false;
			}
		}
	}

	void Animate()
	{
		
	}
	
	void Movement(Vector3 direction)
	{
		Debug.Log(direction);
		rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
	}


	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Wall")
		{
			desiredPos = Vector3.zero;
			canMove = true;

		}
	}
	
}
