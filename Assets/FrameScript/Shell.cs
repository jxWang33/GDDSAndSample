using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shell : MonoBehaviour
{
    protected virtual void Awake() {
    }

    public T CreateDeal<T>(List<Data> datas = null) where T : Deal {
        T temp = Activator.CreateInstance(typeof(T)) as T;
        temp.SetRequire(datas);
        return temp;
    }
    public T CreateDeal<T>(Data data) where T : Deal {
        T temp = Activator.CreateInstance(typeof(T)) as T;
        temp.SetRequire(data);
        return temp;
    }
}
