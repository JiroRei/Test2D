using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enter : MonoBehaviour
{
    private bool enterAllowed;
    public string sceneToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<HOUSE>())
        {
            sceneToLoad = "HouseInteriorPlayer";
            enterAllowed = true;
        }
    } 

    void Update()
    {
        if (enterAllowed &&  Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
