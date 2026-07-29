using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Composites;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour
{
    private UIDocument document;
    private Button StartBut;
    private Button QuitToD;
    

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        StartBut = document.rootVisualElement.Q("Start") as Button;
        QuitToD = document.rootVisualElement.Q("Quit") as Button;
        StartBut.RegisterCallback<ClickEvent>(OnPlayGameCLick);
        QuitToD.RegisterCallback<ClickEvent>(OnExitButtonClick);
    }

    private void OnDisable()
    {
        StartBut.UnregisterCallback<ClickEvent>(OnPlayGameCLick);
    }

    private void OnPlayGameCLick(ClickEvent evt)
    {
        //ForButtonCheck.ButtonCheck = true;
        SceneManager.LoadScene("HowToPlay");
        document.rootVisualElement.ReleaseMouse();
        document.enabled = false;
    }
    private void OnExitButtonClick(ClickEvent evt)
    {
        //ForButtonCheck.ButtonCheck = true;
        Application.Quit();
    }


}

