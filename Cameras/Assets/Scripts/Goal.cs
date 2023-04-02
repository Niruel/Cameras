using UnityEngine;


public class Goal : MonoBehaviour
{
    public GameObject obj;
    public GameObject player;
    public Camera cam3;
    public GameObject gamemenu;
    public bool cleared;
    private void Start()
    {
        cam3.enabled = false;
        cleared = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        //
        cleared = true;
        FindObjectOfType<AudioManager>().Play("clearChime");
        obj.SetActive(true);
        player.SetActive(false);
        gamemenu.SetActive(false);
        cam3.enabled = true;
        if (cam3.enabled==true)
        {
            Time.timeScale = 0f;
        }
       
    }
}
