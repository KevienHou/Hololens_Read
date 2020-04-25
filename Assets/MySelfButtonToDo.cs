using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



[Serializable]
public class MyEvent : UnityEvent
{

}


public class MySelfButtonToDo : MonoBehaviour
{

    public GameObject obj;
    public MyEvent myEvent;

    public void MySetActive()
    {
        if (obj)
        {
            obj.SetActive(!obj.activeSelf);
        }
        Debug.Log("Push");

        myEvent?.Invoke();

    }


}
