using System;
using System.Collections.Generic;
using UnityEngine;
public class G1Manager : MonoBehaviour
{
    private static List<Data> dataList;//数据注册表
    private static List<Deal> dealList;//待处理动作
    private static bool isFirstRun = true;
    public static System.Random rd = new System.Random(GetRandomSeed());

    public static void RegisterData(Data data) {
        dataList.Add(data);
    }
    public static void UnRegisterData(Data data) {
        dataList.Remove(data);
    }
    public static void AddDeal(Deal deal) {
        dealList.Add(deal);
    }
    public static void Clear() {
        dataList = new List<Data>();
        dealList = new List<Deal>();
    }

    public static int GetRandomSeed() {
        byte[] bytes = new byte[4];
        System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
        rng.GetBytes(bytes);
        return BitConverter.ToInt32(bytes, 0);
    }

    void Awake()
    {
        if (isFirstRun) {
            DontDestroyOnLoad(gameObject);
            isFirstRun = false;
        }
        else {
            Destroy(gameObject);
        }
        dataList = new List<Data>();
        dealList = new List<Deal>();
    }

    void Update()
    {
        DealDealList();//动作处理
    }

    void DealDealList() {
        if (dealList.Count == 0)
            return;
        foreach (Deal i in dealList) {
            if (i != null)
                i.Execute();
        }
        dealList = new List<Deal>();//处理结束置空
    }
}