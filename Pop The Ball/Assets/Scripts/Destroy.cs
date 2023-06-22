using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float time = 2.5f;

    private void Start()
    {
        Destroy(gameObject, time);
    }
}
