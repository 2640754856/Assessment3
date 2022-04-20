using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public GameObject human;
    public float value;
    public Vector3 sizeChange;
    public float value2;
    public float value3;

    
    public void MoveLeft() {
       
        value = value - 0.1f;
        human.transform.position = new Vector3(value, value3, value2);
    }
    public void RotateLeft() {
        human.transform.Rotate(0f,20f,0f);
    }
    public void RotateRight()
    {
        human.transform.Rotate(0f,-20f,0f); }
        public void Grow() {
        human.transform.localScale = human.transform.localScale + sizeChange;
    }
    public void ResetHuman() {
        human.transform.position = new Vector3(0, 0, 0);
        human.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        human.transform.localScale = new Vector3(1, 1,1);
    }
    public void MoveRight() {
        value = value + 0.1f;
        human.transform.position = new Vector3(value, value3, value2);
    }
    public void MoveForward() {
       
        value2 = value2 + 0.1f;
        human.transform.position = new Vector3(value, value3, value2);
    }
    public void MoveBack() {
        
        value2 = value2 - 0.1f;
        human.transform.position = new Vector3(value, value3, value2);
    }
}
