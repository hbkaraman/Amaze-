using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCube : MonoBehaviour
{
    private GameObject manager;
    private GameObject player;
    public Material material;
    private Renderer rend;
    
    public bool isCollect;
    private bool oneCreted = true;
    public GameObject particleEffect;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager");
        player = GameObject.FindGameObjectWithTag("Player");
        rend = GetComponent<Renderer>();
    }


    private IEnumerator CreateEffects()
    {
        rend.material = material;
        particleEffect = ObjectPooler.SharedInstance.GetPooledObject(0);
        particleEffect.SetActive(true);
        particleEffect.gameObject.transform.position = player.gameObject.transform.position;  
        oneCreted = false;
        yield return new WaitForSeconds(1f);
        particleEffect.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isCollect = true;
          
            if (isCollect && oneCreted )
            {
               StartCoroutine(CreateEffects());
            }
        }
       
        if (other.gameObject.tag == "Wall")
        {
            isCollect = true;
        }
    }
}
