using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Collision : MonoBehaviour
{
    private CapsuleCollider _capsuleCollider;

    public CapsuleCollider capsuleCollider
    {
        get
        {
            if (_capsuleCollider == null)
            {
                _capsuleCollider = GetComponent<CapsuleCollider>();
            }
            return _capsuleCollider;
        }
    }
    private Rigidbody _rb;
    public Rigidbody rb
    {
        get
        {
            if (_rb == null)
            {
                _rb = GetComponent<Rigidbody>();
            }
            return _rb;
        }
    }

    public virtual void OnEnable()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }

    public virtual void SpawnParticle(Vector3 spawnPoint)
    {
    }

}
