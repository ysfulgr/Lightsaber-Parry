using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField]
    private Transform s_TargetPoint;
    private Swing _swing;
    public Swing swing
    {
        get
        {
            if (_swing == null)
                _swing = GetComponent<Swing>();

            return _swing;
        }
    }
    private Quaternion s_RelativeRotatin { set; get; }
    [SerializeField]
    private bool s_isSimulate;
    [SerializeField]
    private EventNames s_EventNames;
    [SerializeField]
    private EventNames s_EventNameSimulate;
    [SerializeField]
    private EventNames s_EventSimulateAnimation;

    [SerializeField]
    private Transform s_SimulateTransform;
    [SerializeField]
    private LayerMask s_LayerMask;
    public int s_id { get; set; }

    private float timer { set; get; }
    private void Start()
    {
        EventManager.AddEvent<float>(s_EventNames, RotatePlayer);
        EventManager.AddEvent<bool>(s_EventNameSimulate, Simulate);
        s_id = gameObject.GetInstanceID();
    }
    private void Update()
    {
        if (s_isSimulate)
        {
            timer += Time.deltaTime;
            if (timer < 1)
            {
                var diretion = swing.GetDirectionNormalize(transform.position, swing.s_TargetRotation);
                var q = Quaternion.LookRotation(diretion);
                s_RelativeRotatin = swing.GetRotation(transform.rotation, q, timer * swing.s_Multiple);
                transform.rotation = s_RelativeRotatin;
            }
            else
            {
                EventManager.CallEvent<bool>(s_EventSimulateAnimation, true);
                Invoke("StopSimulate", 2.1f);
                s_isSimulate = false;
                timer = 0;
            }
        }
    }

    void StopSimulate()
    {
        EventManager.CallEvent<bool>(s_EventSimulateAnimation, false);
    }
    void RotatePlayer(float value)
    {
        Simulating(value);
    }

    void Simulate(bool isSimulate)
    {
        this.s_isSimulate = isSimulate;
    }
    public Vector3 GetSpawnPoint()
    {
        return s_TargetPoint.position;
    }
    public void SetParent(GameObject go)
    {
        go.transform.SetParent(s_TargetPoint);
    }

    void Simulating(float value)
    {
        s_SimulateTransform.rotation = Quaternion.Euler(0, value, 0);

        Ray ray = new Ray(s_SimulateTransform.position, s_SimulateTransform.TransformDirection(Vector3.forward));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100f, s_LayerMask))
        {
            var script = hit.transform.GetComponent<SpawnPoint>();
            if (script != null && script.s_id != s_id)
            {
                EventManager.CallEvent<string>(EventNames.EventCollisionMessage, "Collision");
                swing.s_TargetRotation = hit.point;
            }
        }
        else
        {
            EventManager.CallEvent<string>(EventNames.EventCollisionMessage, "non Collision");
            swing.s_TargetRotation = transform.position + Random.insideUnitSphere * value;
        }
    }

}
