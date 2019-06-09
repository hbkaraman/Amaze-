using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMove : MonoBehaviour
{

    public Player Player;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Player.canMoveRight = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Player.canMoveRight = true;
        }
    }
}
