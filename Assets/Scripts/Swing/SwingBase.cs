using UnityEngine;

public abstract class SwingBase : MonoBehaviour
{
    public abstract Quaternion GetRotation(Quaternion currentRotation, Quaternion targetRotation,float time);

    public abstract Vector3 GetDirectionNormalize(Vector3 currentRotation, Vector3 targetRotation);
}
