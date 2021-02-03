using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdaptationJoystick : MonoBehaviour
{
    public RectTransform joystick;
    public RectTransform handheld;


    private int _size;
    void Start()
    {
        _size = Camera.main.pixelWidth / 10;

        joystick.sizeDelta = new Vector2(_size * 2, _size * 2);
        handheld.sizeDelta = new Vector2(_size, _size);
    }

}
