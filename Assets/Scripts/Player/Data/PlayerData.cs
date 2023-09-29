using UnityEngine;

[CreateAssetMenu(fileName = "Player Data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _mouseSens;

    public float MaxHealth => _maxHealth;
    public float MoveSpeed => _moveSpeed;
    public float MouseSens => _mouseSens;

    public void SetMoveSpeed(float speed) 
    {
        _moveSpeed = speed;
    }
}
