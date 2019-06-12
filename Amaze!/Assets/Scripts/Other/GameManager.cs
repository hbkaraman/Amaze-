using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private GameObject player;
	public GridCube[] Grids;
	public bool[] isFin;
	private bool isAnimFin;

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
	                   
	                    StartCoroutine(NextLevel());
                    }
                }
    		}
	}

	private IEnumerator NextLevel()
	{
		yield return new WaitForSeconds(2f);
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.buildIndex + 1);
	}

}
