using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Sta()
    {
        SceneManager.LoadScene(1);
        Endclick.IsWin = false;
    }

    public void Tryagain()
    {
        SceneManager.LoadScene(1);
        Endclick.IsWin = false;
    }

    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
}
