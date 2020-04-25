using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class MySliderBackFillAmount : MonoBehaviour
{
    public PinchSlider parentSlider;
    public SpriteRenderer fillImage;

    public Vector2 oriValue;
    public Vector2 remapTo;

    float all;

    private void Awake()
    {
        all = oriValue.y - oriValue.x;
        OnSliderValueUpdate();
    }


    public void OnSliderValueUpdate()
    {
        fillImage.size = new Vector2(parentSlider.SliderValue * all + oriValue.x, fillImage.size.y);
    }


}
