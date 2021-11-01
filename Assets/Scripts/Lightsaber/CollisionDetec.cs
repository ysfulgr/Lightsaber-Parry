using UnityEngine;
public class CollisionDetec : Collision
{

    public override void OnEnable()
    {
        base.OnEnable();
    }


    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        var script = collision.transform.GetComponent<Collision>();
        if (script != null)
        {
            ContactPoint contact = collision.contacts[0];
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 pos = contact.point;
            SpawnParticle(pos);
        }
    }
    public override void SpawnParticle(Vector3 spawnPoint)
    {
        EventManager.CallEvent<Vector3>(EventNames.EventSpawnParticle, spawnPoint);
    }
}
