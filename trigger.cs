using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public logic logicComponent;
    public int sc=1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("logic2");

        foreach (GameObject obj in objectsWithTag)
        {
            logicComponent = obj.GetComponent<logic>();

            // Do something with the logic component...
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logicComponent.addScore(sc);
    }
}