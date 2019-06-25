using System;
using UnityEngine;

public class PressedData : Data
{
    public bool clicked = false;
    public float clickedSize = 0.8f;

    public float currentSize;
    public float targetSize = 1;
    public float sizeSpeed = 5.0f;

    public bool isGood = true;
    public float effect = 10;

    public override Type GetDataType() {
        return GetType();
    }

    protected override void UpdateExpress() {
        Vector2 tempSize = GetComponent<SpriteRenderer>().size;
        tempSize.x = currentSize;
        tempSize.y = currentSize;
        GetComponent<SpriteRenderer>().size = tempSize;
    }

    protected override void Awake()
    {
        base.Awake();
        currentSize = 0;
        SetIsGood(true);
    }
    public void SetSize(float sz) {
        currentSize = targetSize = sz;
    }
    public void SetClickedSize() {
        SetSize(clickedSize);
    }
    public void SetIsGood(bool ig) {
        isGood = ig;
        if (isGood) {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
        else {
            GetComponent<SpriteRenderer>().color = Color.black;
        }
    }
}
