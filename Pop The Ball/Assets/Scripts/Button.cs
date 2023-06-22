using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    public AudioClip audio;
    private AudioSource audioSource;
    public GameObject Panel;

    private void Start()
    {
        Panel = GameObject.Find("Panel");
        audioSource = Panel.GetComponent<AudioSource>();
    }
//
    public void MenuButton()
    {
        StartCoroutine(MenuButton1());
    }
    public void Levels()
    {
        StartCoroutine(LevelsButton());
    }
    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/xdl_production/?next=%2Fkh.doniyor_022%2F");
    }
    public void YouTube()
    {
        Application.OpenURL("https://www.youtube.com/@xdl_production");
    }
    public void StartButton()
    {
        StartCoroutine(StartLevel());

    }
    public void Level2()
    {
       StartCoroutine(Level2Button());
    }
    public void Level3()
    {

        StartCoroutine(Level3But());
    }
    public void Music()
    {
        audioSource.PlayOneShot(audio);
    }

    //Kuratina
    private IEnumerator StartLevel()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("SampleScene");
    }
    private IEnumerator Level2Button()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level2");
    }
    private IEnumerator Level3But()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level3");
    }
    private IEnumerator LevelsButton()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Levels");
    }
    private IEnumerator MenuButton1()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Menu");
    }

}
