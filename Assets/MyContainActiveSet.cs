using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Examples.Demos.EyeTracking;
using UnityEngine;
using UnityEngine.UI;

public class MyContainActiveSet : MonoBehaviour
{

    public List<GameObject> items = new List<GameObject>();


    int current;
    private void Start()
    {
        items[0].SetActive(true);
        current = 0;
    }


    public void Move(int dir)
    {
        current = Mathf.Clamp(current += dir, 0, items.Count - 1);
        Debug.Log(current + "   " + dir);
        for (int i = 0; i < items.Count; i++)
        {
            items[i].SetActive(current == i);
        }
    }

}
