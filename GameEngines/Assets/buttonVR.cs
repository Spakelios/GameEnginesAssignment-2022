using UnityEngine;
using UnityEngine.Events;

public class buttonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    private bool isPressed;
    
    public GameObject menu;
    
    void Start()
    {
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.0015f, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void ShowScreen()
    {
        menu.SetActive(true);
    }
    
}
