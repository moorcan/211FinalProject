using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi");
        GameObject routerGameObject1 = GameObject.Find("r1");
        GameObject routerGameObject2 = GameObject.Find("r2");
        GameObject routerGameObject3 = GameObject.Find("r3");
        GameObject routerGameObject4 = GameObject.Find("r4");
        GameObject routerGameObject5 = GameObject.Find("r5");


        Router r1;
        Router r2;
        Router r3;
        Router r4;
        Router r5;

        if (routerGameObject1 != null)
        {
            r1 = routerGameObject1.GetComponent<Router>();
            r2 = routerGameObject2.GetComponent<Router>();
            r3 = routerGameObject3.GetComponent<Router>();
            r4 = routerGameObject4.GetComponent<Router>();
            r5 = routerGameObject5.GetComponent<Router>();

            //NOW Wire them together
            r1.connectedRouters.Add(r2);
            r2.connectedRouters.Add(r1);

            r4.connectedRouters.Add(r5);
            r5.connectedRouters.Add(r4);
            


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


