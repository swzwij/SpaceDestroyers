using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMain : MonoBehaviour
{
    public void main()
    {
        SceneManager.LoadScene("Main");
    }
}
