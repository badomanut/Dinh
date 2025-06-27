using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakeManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Observe.Notify("upDateUI", 10);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Observe.Notify("upDateUI", 2000);
        }
    }
}

