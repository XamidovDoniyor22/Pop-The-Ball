using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLevels : MonoBehaviour
{
    public GameObject[] balls;
    private int random;

    private void FixedUpdate()
    {
        RandomSpawn();
    }

    private void RandomSpawn()
    {
        random = Random.Range(0, balls.Length);
        Instantiate(balls[random], transform.position, Quaternion.identity);
    } 
}
