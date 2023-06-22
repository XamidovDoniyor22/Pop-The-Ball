using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int numberCount;
    public GameObject Panel;
    public Text NumberText;

    public GameObject[] balls;


    private void Start()
    {
        Panel.SetActive(false);
        balls = new GameObject[balls.Length];
      
    }
    private void Update()
    {
        Check();
    }
    public void Number()
    {
        numberCount++;
        NumberText.text = "" + numberCount;
    }
    private void Check()
    {
        if(numberCount == balls.Length)
        Panel.SetActive(true);
    }
}
