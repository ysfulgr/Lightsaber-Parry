using UnityEngine;

public class Swing : SwingBase
{
    public float s_Multiple;

    public Vector3 s_TargetRotation { set; get; }

    public override Quaternion GetRotation(Quaternion currentRotation, Quaternion targetRotation, float speed)
    {
        return Quaternion.Lerp(currentRotation, targetRotation, speed);
    }

    public override Vector3 GetDirectionNormalize(Vector3 currentRotation, Vector3 targetRotation)
    {
        var direction = targetRotation - currentRotation;
        direction.Normalize();
        direction.y = 0;
        return direction.normalized;
    }
}
