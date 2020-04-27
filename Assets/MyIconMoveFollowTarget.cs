using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyIconMoveFollowTarget : MonoBehaviour
{

    public GameObject tar;

    RectTransform rectTransform;

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tar != null)
        {
            rectTransform.position = tar.transform.position;
        }
    }
}
