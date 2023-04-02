using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TranslateText : MonoBehaviour
{
    public Animation animation;
    public Text text;
    public RawImage image;
    public GameObject go;
    bool hasplayed = false;
    bool isOpen = false;
    public Goal goal;
    private void Start()
    {
        Time.timeScale = 0f;
        image.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && hasplayed==false)
        {
            animation.Play();
            text.enabled = false;
            image.enabled = true;
            hasplayed = true;
            Time.timeScale = 1f;
        }
        if (Input.GetKeyDown(KeyCode.Q) && isOpen==false && hasplayed )
        {
            go.SetActive(true);
            isOpen = true;
            Time.timeScale = 0f;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Q)&& isOpen || goal.cleared)
            {
                go.SetActive(false);
                isOpen = false;
                Time.timeScale = 1f;
            }
        }
    }
    public void ResumeGame()
    {
        if (isOpen)
        {
            go.SetActive(false);
            isOpen = false;
            Time.timeScale = 1f;
        }
    }
    public void SelectionScreen()
    {
        SceneManager.LoadScene(6);
    }
    public void Return_to_Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
