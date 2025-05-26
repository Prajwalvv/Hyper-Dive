using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InappPurchaseButtonSkinShop : MonoBehaviour
{
    public enum PurchaseType { gems7500,gems15000,gems50000,gems75000,gems100000,gems250000};
    public PurchaseType purchaseType;


    public void ClickPurchaseButton(){
        switch (purchaseType){
            case PurchaseType.gems7500:
                IAPManager.instance.BuyGems7500();
                break;
            case PurchaseType.gems15000:
                IAPManager.instance.BuyGems15000();
                break;
            case PurchaseType.gems50000:
                IAPManager.instance.BuyGems50000();
                break;
            case PurchaseType.gems75000:
                IAPManager.instance.BuyGems75000();
                break;
            case PurchaseType.gems100000:
                IAPManager.instance.BuyGems100000();
                break;
            case PurchaseType.gems250000:
                IAPManager.instance.BuyGems250000();
                break;

        }
    }
}
