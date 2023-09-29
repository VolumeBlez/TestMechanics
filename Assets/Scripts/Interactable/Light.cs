using UnityEngine;

public class Light : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject _light;
    [SerializeField] private bool _isLightActive = false;

    public void Interact(IPlayerPresenter presenter)
    {
        _isLightActive = !_isLightActive;
        _light.SetActive(_isLightActive);
    }

}
