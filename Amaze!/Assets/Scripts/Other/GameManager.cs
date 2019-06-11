using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
	private GameObject player;
	public GridCube[] Grids;
	public bool[] isFin;
	private bool oneTime = true;
	private void Start()
	{
	}

	private void Update()
	{
		EndGame();
	}

	void EndGame()
	{
	    for (int i = 0; i < Grids.Length; i++)
    		{
    			if (Grids[i].isCollect)
    			{
    				isFin[i] = true;

                    if (isFin.All(isFin => isFin))
                    {
	                    if(Grids.All(Grids => Grids))
	                    {
						  Grids[i].transform.Rotate(0,0,90f*Time.deltaTime);   
	                    }
                    }
                }
    		}
	}
}
