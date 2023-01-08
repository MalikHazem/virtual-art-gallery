using UnityEngine;
using UnityEngine.UI;
using ArabicSupport;


public class NewBehaviourScript : MonoBehaviour
{
    public int painNum;

    public string url;
    public string url2;
    string url3;
    public string title;

    public ImageDownloader image;

    public Api j;
    public Renderer renderer;

    public string id;
    public Text p_name;
    public Text a_name;
    public Text price;
    public Text details;
    public Text category;
    /*public Text date;*/

    public Button buttonsearch;

    [SerializeField] public GameObject buy;
    [SerializeField] public GameObject sold;
    [SerializeField] public GameObject canvas;
    [SerializeField] public GameObject search;

    [SerializeField] InputField inputsearch;

    bool isDone = false;
    public bool ShowTashkeel = false;
    public bool UseHinduNumbers = true;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();

        Button btn = buttonsearch.GetComponent<Button>();
        btn.onClick.AddListener(onclick);
    }
    void onclick()
    {
        url3 = url;
        url = url2 + inputsearch.text;
    }
    // Update is called once per frame
    void Update()
    {
        ///// Search
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            search.SetActive(true);
        }

        bool IsActive = canvas.activeInHierarchy == true; 
        if (IsActive)
        {
            if (!isDone)
            {
                Switchpain(url, url3);
                isDone = true;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                canvas.SetActive(false);
            }
        }
        else
        {
            isDone = false;
        }
    }
    void Switchpain(string u , string u2)
    {
        url = u;
        j = api.GetApi(u);

        if (j == null)
        j = api.GetApi(u2);
        
        id = j.id;

        if(j.booked == "1")
        {
            buy.SetActive(false);
            sold.SetActive(true);
        }

        ImageDownloader.instance.Download(j.image);

        j.p_name = ArabicFixer.Fix(j.p_name, ShowTashkeel, UseHinduNumbers);
        p_name.text = "Painting Name: " + j.p_name;

        j.a_name = ArabicFixer.Fix(j.a_name, ShowTashkeel, UseHinduNumbers);
        a_name.text = "artist Name: " + j.a_name;

        /*j.price = ArabicFixer.Fix(j.price, ShowTashkeel, UseHinduNumbers);*/
        price.text = "Price: " + "$" + j.price;

        j.details = ArabicFixer.Fix(j.details, ShowTashkeel, UseHinduNumbers);
        details.text = "Details: " + j.details;

        j.name = ArabicFixer.Fix(j.name, ShowTashkeel, UseHinduNumbers);
        category.text = "Category: " + j.name;
    }    
}

