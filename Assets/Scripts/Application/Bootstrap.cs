using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private PlayerSetup _playerSetup;
    [SerializeField] private ProductCreatorView _productCreatorView;

    private void Start()
    {
        ProductCreator creatorPresenter = new(5f);
        _productCreatorView.Init(creatorPresenter);

        _playerSetup.Init();
    }
}
