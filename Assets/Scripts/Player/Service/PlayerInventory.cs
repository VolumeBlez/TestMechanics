using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private int _maxCount;
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
