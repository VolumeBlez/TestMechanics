using UnityEngine;

public class Light : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject _light;
    [SerializeField] private bool _isLightActive = false;

    public void Interact()
    {
        _isLightActive = _isLightActive? false : true;
        _light.SetActive(_isLightActive);
    }

}
