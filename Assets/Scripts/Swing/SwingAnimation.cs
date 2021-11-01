using UnityEngine;
public class SwingAnimation : MonoBehaviour
{
    private Animator _animation;
    public Animator animation
    {
        get
        {
            if (_animation == null)
                _animation = GetComponentInChildren<Animator>();

            return _animation;
        }
    }
    [SerializeField]
    EventNames s_EventNames;
    private bool s_isFight { set; get; }
    private void Start()
    {
        EventManager.AddEvent<bool>(s_EventNames, success =>
        {
            s_isFight = success;
            animation.SetBool("fight", s_isFight);
        });
    }

    private void Update()
    {
        animation.SetBool("fight", s_isFight);
    }
}
