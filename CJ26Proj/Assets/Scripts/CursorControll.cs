using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorControll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Awake()
    {
        
        // Only lock the cursor if we are in a gameplay scene
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}

    

