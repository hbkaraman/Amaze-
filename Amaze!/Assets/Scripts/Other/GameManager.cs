using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	private GameObject player;
	public GridCube[] Grids;
	public bool[] isFin;
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
    			if (Grids[i].isCollect == true )
    			{
    				isFin[i] = true;
    			}

                for (int j = 0; j < isFin.Length; j++)
                {
	                if (isFin[j] == true)
	                {
		                Debug.Log("GameEnd");
	                }
                }
    			
    		}
	
		/*for (int i = 0; i < Grids.Length; i++)
		{
			if (Grids[i].isCollect == true )
			{
				isFin[i] = true;
			}

			if (isFin[0] && isFin[1] && isFin[3] && isFin[4] && isFin[5] && isFin[6]&& isFin[7] && isFin[8]
			    && isFin[9] && isFin[10]&& isFin[11] && isFin[12]&& isFin[13] && isFin[14]&& isFin[15] && isFin[16]
			    && isFin[17] && isFin[18]&& isFin[19] && isFin[20]&& isFin[21] && isFin[22]&& isFin[23] && isFin[24]
			    && isFin[25] && isFin[26]&& isFin[27] && isFin[28]&& isFin[29] && isFin[30]&& isFin[31] && isFin[32])
			{
				Debug.Log("GameEnd");
			}
		}*/
	}
	
	/*if (Grid.GetLength(3).)
	{
		
	}*/
}
