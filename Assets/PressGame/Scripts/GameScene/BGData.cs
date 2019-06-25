using System;
using UnityEngine;

public class BGData : Data
{
    public float speed = 0;
    public float speedA = 0.1f;

    public float currentSize;
    public float targetSize = 0;
    public float sizeSpeed = 5.0f;
    public float maxSize = 21.6f;

    public override Type GetDataType() {
        return GetType();
    }

    protected override void UpdateExpress() {
        Vector2 tempSize = GetComponent<SpriteRenderer>().size;
        tempSize.y = currentSize;
        GetComponent<SpriteRenderer>().size = tempSize;
    }

    protected override void Awake() {
        base.Awake();
        currentSize = 0;
    }
    public void SetSize(float sz) {
        currentSize = targetSize = sz;
    }
}
