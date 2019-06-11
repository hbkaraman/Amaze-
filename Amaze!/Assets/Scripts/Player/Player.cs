using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	public CameraShake camshake;
	public LayerMask playerMask;
	public Swipe swipeCont;
	private Vector3 _desiredPos = Vector3.zero;
	public float speed ;
	public bool _canMove = true;
	private void Start()
	{
		_desiredPos = transform.position;
	}

	private void FixedUpdate()
	{
		Movement();
		PlayerTransform();
	}
	private void Update()
	{
		Animate();
	}
		
	void Animate()
	{
		
	}
	
	void Movement()
	{
		RaycastHit hit;
		if (_canMove)
		{
			if (swipeCont.SwipeLeft)
			{
				if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, Mathf.Infinity , playerMask))
				{
					_desiredPos.x = hit.transform.position.x + 1;
					_canMove = false;
				}
			}
			else if (swipeCont.SwipeRight)
			{
				if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, Mathf.Infinity , playerMask))
				{
					_desiredPos.x = hit.transform.position.x - 1;
					_canMove = false;
				}
			}
			else if (swipeCont.SwipeUp)
			{
				if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity , playerMask))
				{
					_desiredPos.z = hit.transform.position.z - 1;
					_canMove = false;
				}
			}
			else if (swipeCont.SwipeDown)
			{
				if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out hit, Mathf.Infinity , playerMask))
				{
					_desiredPos.z = hit.transform.position.z + 1;
					_canMove = false;
				}
			}	
		}
	}

	void PlayerTransform()
	{
		if (transform.position != _desiredPos)
		{
			transform.position = Vector3.MoveTowards(transform.position, _desiredPos, speed * Time.deltaTime);
			camshake.Shake();
		}
		else
		{
			_canMove = true;
		}
	}

}
