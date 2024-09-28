using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController playerController;

    public GameObject obstaclePrefab;
    private float startDelay = 2f;
    private float repeatRate = 2f;
    // Start is called before the first frame update
    void Start()
    {
        playerController = FindAnyObjectByType<PlayerController>();

        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (!playerController.isGameover)
        {
            Instantiate(obstaclePrefab, transform.position, obstaclePrefab.transform.rotation);
        }
    }
}
