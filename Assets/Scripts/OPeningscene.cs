using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OPeningscene : MonoBehaviour
{
    // Start is called before the first frame update
    public void BeginGame()
    {
        SceneManager.LoadScene(1);
    }
}
