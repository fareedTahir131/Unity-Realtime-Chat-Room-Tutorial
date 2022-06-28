using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UserNameManager : MonoBehaviour
{
    public InputField Username;
    public static string Name;

    public void SetUsername()
    {
        Name = Username.text;
        SceneManager.LoadScene(1);
    }

}
