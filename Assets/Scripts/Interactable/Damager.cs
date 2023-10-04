using DigitalRuby.LightningBolt;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] private LightningBoltScript _lightning;

    [Header("Knockback")]
    [SerializeField] private ForceMode _forceMode;
    [SerializeField] private float _force = 2f;
    [SerializeField, Min(0)] private int _damage  = 10;


    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.TryGetComponent(out PlayerPresenterView presenterView))
        {
            _lightning.gameObject.SetActive(true);
            _lightning.EndObject = other.gameObject;

            presenterView.Presenter.Health.Decrement(_damage);
            float DX = presenterView.transform.position.x - transform.position.x;
            float DZ = presenterView.transform.position.z - transform.position.z;

            presenterView.Presenter.SetImpact(new Vector3(DX, 3f, DZ), _force, _forceMode);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _lightning.EndObject = null;
        _lightning.gameObject.SetActive(false);
    }
}
