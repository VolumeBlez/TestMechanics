using UnityEngine;

[CreateAssetMenu(fileName = "Player Data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _mouseSens;

    public int MaxHealth => _maxHealth;
    public float MoveSpeed => _moveSpeed;
    public float MouseSens => _mouseSens;

    public void SetMoveSpeed(float speed) 
    {
        _moveSpeed = speed;
    }

    public void SetMaxHealth(int maxHealth) 
    {
        _maxHealth = maxHealth;
    }
}
