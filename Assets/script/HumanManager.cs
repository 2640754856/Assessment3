using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public GameObject Person;
    public float value;
    public float value1;
    public Vector3 sizeChange;
    public void MoveLeft()
    {
        value = value - 1f;
        Person.transform.position = new Vector3(value, 1, value1);
    }
    public void Go()
    {
        value1 = value1 + 2f;
        Person.transform.position = new Vector3(value, 1, value1);
    }
    public void Goback()
    {
        value1 = value1 - 2f;
        Person.transform.position = new Vector3(value, 1, value1);
    }
    public void MoveRight()
    {
        value = value + 1f;
        Person.transform.position = new Vector3(value, 1,value1);
    }
    public void RotateLeft()
    {
        Person.transform.Rotate(0f,-15f, 0f);

    }
    public void RotateRight()
    {
        Person.transform.Rotate(0f, 15f, 0f);

    }
    public void Grow()
    {
        Person.transform.localScale = Person.transform.localScale + sizeChange;

    }
    public void ResetHuman()
    {
        Person.transform.position = new Vector3(171, 1,-156);
        Person.transform.rotation = Quaternion.Euler(new Vector3(0, 0,0));
        Person.transform.localScale = new Vector3(10, 10, 10);

    }
}
