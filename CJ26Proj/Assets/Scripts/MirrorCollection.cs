using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MirrorCollection : MonoBehaviour
{
    [SerializeField] private float DisToMirror;

    [SerializeField] private GameObject[] Mirrors;
    [SerializeField] private int iMirrorCount = 0;
    private void Mirror()
    {
        iMirrorCount = 0;
        foreach (GameObject mirror in Mirrors)
        {
            if (mirror.activeSelf)
            {
                DisToMirror = Vector3.Distance(transform.position, mirror.transform.position);
                if (DisToMirror <= 3.0f)
                {
                    mirror.SetActive(false);
                    ;
                }
            }
            else { iMirrorCount++; }
        }
        if (iMirrorCount >= Mirrors.Length)
        {
            SceneManager.LoadScene("StartMenu");
        }
    }
    private void Update()
    {
        Mirror();
    }
}
