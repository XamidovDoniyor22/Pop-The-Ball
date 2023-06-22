using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poping : MonoBehaviour
{
    public GameManager num;

    [Header("Sound")]
    public AudioClip audio;
    public AudioSource audioSource;

    private void Start()
    {
        num = GameObject.Find("BallContainer").GetComponent<GameManager>();
        audioSource = num.GetComponent<AudioSource>();
    } 
    private void OnMouseDown()
    {
        audioSource.PlayOneShot(audio);
        num.Number();
        Destroy(this.gameObject);
    }
}
