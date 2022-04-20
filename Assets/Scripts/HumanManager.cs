using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public GameObject human;
    public float valueX = 0;
    public float valueY = 0;
    public Vector3 sizeChange;
    

    public void MoveLeft()
    {
        valueX = valueX - 1f;
        human.transform.position = new Vector3(valueX, 0, valueY);
    }

    public void MoveRight()
    {
        valueX = valueX + 1f;
        human.transform.position = new Vector3(valueX, 0, valueY);
    }

    public void MoveUp()
    {
        valueY = valueY - 1f;
        human.transform.position = new Vector3(valueX, 0, valueY);
    }

    public void MoveDown()
    {
        valueY = valueY + 1f;
        human.transform.position = new Vector3(valueX, 0, valueY);
    }

    public void RotateLeft()
    {
        human.transform.Rotate(0f, 20f, 0f);
    }

    public void RotateRight()
    {
        human.transform.Rotate(0f, -20f, 0f);
    }

    public int a = 0;

    public void InsA()
    {
        a = a + 1;
    }

    public void GrowHuman()
    {
        InsA();
        human.transform.localScale = new Vector3(a, a, a);
    }

    public void RelA()
    {
        a = 0;
    }

    public  void RelXV()
    {
        valueX = 0;
    }

    public void RelYV()
    {
        valueY = 0;
    }

    public void ResetHuman()
    {
        RelA();
        RelXV(); 
        RelYV();
        human.transform.position = new Vector3(0, 0, 0);
        human.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        human.transform.localScale = new Vector3(1, 1, 1);
    }
}

