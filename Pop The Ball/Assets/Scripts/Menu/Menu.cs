using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public GameObject balls;
    public Transform point;

    private void Start()
    {
        balls = GameObject.Find("Ball1");
        StartCoroutine(Create());
    }
    private void Update()
    {
   
    }
    private IEnumerator Create()
    {
        while (true)
        {
            Instantiate(balls, point.position, transform.rotation);
        }
    }
}
