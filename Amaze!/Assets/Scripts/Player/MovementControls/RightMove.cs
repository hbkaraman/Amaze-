using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMove : MonoBehaviour
{

    public SwipePlayer Player;
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
