using UnityEngine;

public class MiddlePointCalculator : MonoBehaviour
{
    // The two game objects whose middle point we want to calculate.
    public GameObject obj1;
    public GameObject obj2;

    // The calculated middle point between the two game objects.
    private Vector3 middlePoint;
    float distance;
    WindZone wind;
    private void Start()
    {
        wind = gameObject.GetComponent<WindZone>();
    }
    void Update()
    {
        // Calculate the middle point between the two game objects.
        gameObject.transform.position = (obj1.transform.position + obj2.transform.position) / 2;
        distance = Vector3.Distance(obj1.transform.position, obj2.transform.position);
        wind.radius = distance*distance;
        // You can use the middlePoint variable to move another game object or do something else with it.
    }
}