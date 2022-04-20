using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Player;

    public GameObject bullt;
    public Transform gun;
    private int bullts = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.position);

        float x = Player.position.x - transform.position.x;
        float y = Player.position.y - transform.position.y;
        float z = Player.position.z - transform.position.z;

        if (Mathf.Sqrt((x * x) + (y * y) + (z * z)) < 100)
        {
            if (bullts > 0)
            {
                Instantiate(bullt, gun.position, gun.rotation);
                bullts--;
            }

        }
        if (Mathf.Sqrt((x * x) + (y * y) + (z * z)) < 20)
        {
            Endclick.IsWin = true;
        }
    }
}
