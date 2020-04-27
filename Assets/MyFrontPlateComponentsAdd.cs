using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;



[RequireComponent(typeof(CanvasGroup))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(BoxCollider))]
public class MyFrontPlateComponentsAdd : MonoBehaviour
{
    private PressableButtonHoloLens2 pressableButton;
    private Animator anim;
    private RectTransform rectTransform;

    private void Awake()
    {
        GetComponent<CanvasGroup>().alpha = 0;
        rectTransform = transform.parent.GetComponent<RectTransform>();
        GetComponent<BoxCollider>().size = new Vector3(rectTransform.rect.width, rectTransform.rect.height, rectTransform.localPosition.z);
        pressableButton = transform.parent.GetComponent<PressableButtonHoloLens2>();
        anim = GetComponent<Animator>();
        pressableButton.ButtonPressed.AddListener(AnimPush);
        pressableButton.ButtonReleased.AddListener(AnimRelease);

    }

    private void AnimPush()
    {
        anim.SetTrigger("Push");
    }

    private void AnimRelease()
    {
        anim.SetTrigger("Release");
    }


}
