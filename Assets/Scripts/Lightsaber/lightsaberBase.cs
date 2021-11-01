using UnityEngine;

public abstract class LightsaberBase : MonoBehaviour
{
    public Color l_LightColorStart { set; get; }
    public Color l_LightColorEnd { set; get; }

    protected float l_TextureOffset = 0;

    protected float l_TextureOffsetSpeed = 2f;

    protected float l_TextureOffsetHigh = -5f;

    protected float l_TextureOffsetIcrease = 5f;
    public abstract void SetColor();
    public float SetTextureOffset()
    {
        l_TextureOffset -= Time.deltaTime * l_TextureOffsetSpeed;
        if (l_TextureOffset < l_TextureOffsetHigh)
        {
            l_TextureOffset += l_TextureOffsetIcrease;
        }
        return l_TextureOffset;
    }
}
