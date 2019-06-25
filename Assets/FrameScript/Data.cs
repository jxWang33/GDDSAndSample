using System;
using UnityEngine;

public abstract class Data : MonoBehaviour
{
    public abstract Type GetDataType();
    protected abstract void UpdateExpress();

    protected virtual void Awake() {
        G1Manager.RegisterData(this);//注册
    }
    protected virtual void Update() {
        UpdateExpress();
    }
    private void UnRegister() {
        G1Manager.UnRegisterData(this);
    }
    public void SetDestroy() {
        Destroy(gameObject);
    }
}
 