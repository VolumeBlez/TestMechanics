using UnityEngine;

public class PlayerInventory
{
    private int _maxCount = 4;
    private int _count = 0;

    public void Increase()
    {
        if(_count + 1 == _maxCount) return;
        _count++;
    }

    public void Decrease()
    {
        if(_count < 2) return;
        _count--;
    }
}
