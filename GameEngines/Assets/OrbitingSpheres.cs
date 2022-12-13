using UnityEngine;

public class OrbitingSpheres : MonoBehaviour
{
    // The game object that the spheres will orbit around.
    public GameObject centerObject;

    // The two spheres that will orbit around the center object.
    public GameObject sphere1;
    public GameObject sphere2;

    // The radius of the orbit.
    public float orbitRadius = 5;

    // The speed at which the spheres orbit.
    public float orbitSpeed = 1;

    void Update()
    {
        // Calculate the new positions of the spheres based on their current positions and the orbit radius and speed.
        var sphere1Position = centerObject.transform.position + new Vector3(Mathf.Cos(Time.time * orbitSpeed), 0, Mathf.Sin(Time.time * orbitSpeed)) * orbitRadius;
        var sphere2Position = centerObject.transform.position + new Vector3(Mathf.Cos(Time.time * orbitSpeed + Mathf.PI), 0, Mathf.Sin(Time.time * orbitSpeed + Mathf.PI)) * orbitRadius;

        // Update the positions of the spheres in the scene.
        sphere1.transform.position = sphere1Position;
        sphere2.transform.position = sphere2Position;
    }
}
