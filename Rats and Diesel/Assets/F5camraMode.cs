using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;
    private bool isCamera1Active = true;

    void Start()
    {
        // Ensure Camera1 starts as active and Camera2 as inactive
        Camera1.gameObject.SetActive(true);
        Camera2.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            // Toggle cameras
            isCamera1Active = !isCamera1Active;
            Camera1.gameObject.SetActive(isCamera1Active);
            Camera2.gameObject.SetActive(!isCamera1Active);
        }
    }
}

