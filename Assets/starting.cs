using UnityEngine;
using UnityEngine.SceneManagement;
public class starting : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private bool spacePressed = false;

    void Update()
    {
        if (!spacePressed && Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
            PlayerPrefs.SetInt("AIMode", 0); // Manual mode
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void PlayWithAI()
    {
        PlayerPrefs.SetInt("AIMode", 1);
        SceneManager.LoadScene("SampleScene");
    }
}
