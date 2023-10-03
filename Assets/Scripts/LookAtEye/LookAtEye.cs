using UnityEngine;

public class LookAtEye : MonoBehaviour
{
    [SerializeField] private Transform _target;

    void Update()
    {
        transform.LookAt(_target);
    }
}
