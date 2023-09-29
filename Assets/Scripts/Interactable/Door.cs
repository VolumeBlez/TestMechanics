using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator _anim;
    [SerializeField] private AnimationClip _openClip;
    [SerializeField] private AnimationClip _closeClip;
    [SerializeField] private bool _isOpened;

    public void Interact()
    {
        _isOpened = _isOpened ? false : true;

        if(_isOpened)
            _anim.Play(_openClip.name);
        else
            _anim.Play(_closeClip.name);
    }
}
