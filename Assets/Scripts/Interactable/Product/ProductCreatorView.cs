using UnityEngine;

public class ProductCreatorView : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject _productReadyTagObject;

    private ProductCreator _creatorPresenter;
    private bool _isMaxProductCount = false;

    public void Init(ProductCreator creatorPresenter)
    {
        _creatorPresenter = creatorPresenter;
        _creatorPresenter.ProductCreated += SetMaxProductCount; // max count of product = 1
    }

    public void Interact(IPlayerPresenter playerPresenter)
    {
        if(_creatorPresenter.TryRemoveProduct() == true) 
        {
            _isMaxProductCount = false;
            _productReadyTagObject.SetActive(false);

            playerPresenter.Inventory.AddProduct();
        }

    }

    void Update()
    {
        if(_isMaxProductCount) return;

        _creatorPresenter.UpdateTime(Time.deltaTime);
    }

    private void SetMaxProductCount()
    {
        _isMaxProductCount = true;
        _productReadyTagObject.SetActive(true);
    }
}
