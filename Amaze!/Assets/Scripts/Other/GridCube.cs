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

    private void Update()
    {
       
    }

    void CreateParticleEffect()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isCollect = true;
          
            if (isCollect == true && oneCreted == true)
            {
                rend.material = material;
                particleEffect = ObjectPooler.SharedInstance.GetPooledObject(0);
                particleEffect.SetActive(true);
                particleEffect.gameObject.transform.position = player.gameObject.transform.position;  
                oneCreted = false;
            }
        }
    }
}
