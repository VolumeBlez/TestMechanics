using System;
using UnityEngine;

public sealed class PlayerInventory
{
    public Action ProductCountChanged;

    private int _maxProductCount = 4;
    private int _productCount = 0;

    public int ProductCount => _productCount;

    public void AddProduct()
    {
        if(_productCount == _maxProductCount) return;
        _productCount++;
        ProductCountChanged?.Invoke();
    }

    public void RemoveProduct()
    {
        if(_productCount <= 0) return;
        _productCount--;
        ProductCountChanged?.Invoke();
    }
}
