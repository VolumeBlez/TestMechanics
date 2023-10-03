using System;

public class ProductCreator
{
    public Action ProductCreated;

    private readonly float _creationReloadTime;
    private float _currentTime;
    private int _productCount;

    public ProductCreator(float reloadTime)
    {
        _creationReloadTime = reloadTime;
        _currentTime = 0f;
        _productCount = 0;
    }

    public void UpdateTime(float deltaTime)
    {
        if(_currentTime >= _creationReloadTime)
        {
            _currentTime = 0f;
            _productCount++;
            ProductCreated?.Invoke();
            return;
        }

        _currentTime += deltaTime;
    }

    public bool TryRemoveProduct()
    {
        if(_productCount <= 0) return false;
        _productCount--;

        return true;
    }
}
