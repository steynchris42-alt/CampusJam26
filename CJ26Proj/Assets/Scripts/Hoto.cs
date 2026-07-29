using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Composites;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class hoto : MonoBehaviour
{
    private UIDocument document;
    private Button nextbut;
    
  

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        nextbut = document.rootVisualElement.Q("NEXT") as Button;
  
        nextbut.RegisterCallback<ClickEvent>(OnPlayGameCLick);
       
    }

    private void OnDisable()
    {
        nextbut.UnregisterCallback<ClickEvent>(OnPlayGameCLick);
    }

    private void OnPlayGameCLick(ClickEvent evt)
    {
        //ForButtonCheck.ButtonCheck = true;
        if (document != null && document.rootVisualElement != null)
        {
            document.rootVisualElement.ReleaseMouse();
            document.enabled = false; 
        }
        SceneManager.LoadScene("MainGameSpace");
    }



}

