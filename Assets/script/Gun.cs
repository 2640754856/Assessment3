using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;

    public Transform hand;

    public GameObject[] gun;
    private int list = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && list < gun.Length - 1)
        {
            gun[list].gameObject.SetActive(false);
            list++;
            gun[list].gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Q) && list > 0)
        {
            gun[list].gameObject.SetActive(false);
            list--;
            gun[list].gameObject.SetActive(true);
        }

        //点击鼠标左键开火
        if (Input.GetMouseButtonDown(0))
        {
            //创建子弹
            Instantiate(bullet, hand.position, hand.rotation);
        }
    }
}
