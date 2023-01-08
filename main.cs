using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject canvas2;

    

    public Text Name;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void loads()
    {
        SceneManager.LoadScene("Test_Map");
    }

    public void Setting()
    {
        canvas.SetActive(false);
        canvas2.SetActive(true);
    }
    public void Esc()
    {
        canvas.SetActive(true);
        canvas2.SetActive(false);
    }

}
