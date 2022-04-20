using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endclick : MonoBehaviour
{
    public static bool IsWin = false;
    public GameObject end;

    // Start is called before the first frame update
    void Start()
    {
        end.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsWin)
        {
            end.SetActive(true);
        }
        else
        {
            end.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsWin = true;
        }
    }
}
