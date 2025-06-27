using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObserve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observe.AddObserve("upDateUI", onUpdateUI);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDestroy()
    {
        Observe.RemoveListener("upDateUI", onUpdateUI);
    }

    void onUpdateUI(object[] datas) {
        Debug.LogError(" UI updated!"+ (int)datas[0]);
    }
}

