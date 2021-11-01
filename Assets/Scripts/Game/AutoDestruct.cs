using System.Collections;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class AutoDestruct : MonoBehaviour
{
    // If true, deactivate the object instead of destroying it
    [SerializeField] bool d_OnlyDeactivate;
    [SerializeField] float d_Delay;
    void OnEnable()
    {
        StartCoroutine("CheckIfAlive");
    }

    IEnumerator CheckIfAlive()
    {
        ParticleSystem ps = this.GetComponent<ParticleSystem>();

        while (true && ps != null)
        {
            yield return new WaitForSeconds(d_Delay);
            if (!ps.IsAlive(true))
            {
                if (d_OnlyDeactivate)
                {
                    this.gameObject.SetActive(false);
                }
                else
                    Destroy(this.gameObject);
                break;
            }
        }
    }
}
