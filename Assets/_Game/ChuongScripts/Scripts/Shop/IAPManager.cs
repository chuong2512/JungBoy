using System;
using System.Collections;
using ChuongCustom;
using UnityEngine;

public class IAPKey
{
    public const string PACK1 = "pack_gem_1";
    public const string PACK2 = "pack_gem_2";
    public const string PACK3 = "pack_gem_3";
    public const string PACK4 = "pack_gem_4";
    public const string PACK5 = "pack_gem_5";
}

public class IAPManager : PersistentSingleton<IAPManager>
{
   
    public static Action OnPurchaseSuccess;

    private bool _isBuyFromShop;

    private void Start()
    {
        InitIAP();
    }

    private void InitIAP()
    {
       
    }


}