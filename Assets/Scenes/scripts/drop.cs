using UnityEngine;

public class drop : MonoBehaviour
{
    public Transform t;
    public GameObject p;
    private int id = 0;

    public float[][] effectList;

    void Start()
    {
        effectList = new float[5][];
        for (int i = 0; i < 5; i++)
            effectList[i] = new float[5];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) id = 0;
        if (Input.GetKeyDown(KeyCode.Alpha2)) id = 1;
        if (Input.GetKeyDown(KeyCode.Alpha3)) id = 2;
        if (Input.GetKeyDown(KeyCode.Alpha4)) id = 3;
        if (Input.GetKeyDown(KeyCode.Alpha5)) id = 4;

        if (Input.GetMouseButtonDown(0))
        {
            GameObject e = Instantiate(p, t);
            poiton Ee = e.GetComponent<poiton>();

            Ee.radius = effectList[id][0];
            Ee.dmg = effectList[id][1];
            Ee.time = effectList[id][2];
            Ee.expandSpeed = effectList[id][3];
            Ee.damageDelay = effectList[id][4];
        }
    }
}
