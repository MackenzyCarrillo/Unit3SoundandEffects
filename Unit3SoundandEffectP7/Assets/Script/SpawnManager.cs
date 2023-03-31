using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obsticlePrefab;
  
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playercControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
       playercControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObsticle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObsticle()
    {
        int obsticleIndex = Random.Range(0, obsticlePrefab.Length);
        if (playercControllerScript.gameOver == false)
       {
            Instantiate(obsticlePrefab[obsticleIndex], spawnPos, obsticlePrefab[obsticleIndex].transform.rotation);
       }
        
    }




}
