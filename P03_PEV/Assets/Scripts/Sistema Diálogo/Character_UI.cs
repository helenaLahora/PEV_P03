using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Character_UI : MonoBehaviour
{

    public CharacterStats CharacterObject;

    public Image Image;
    public TextMeshProUGUI NameText;

    // Start is called before the first frame update
    void Start()
    {
        SetStuff(CharacterObject);
    }

    private void SetStuff(CharacterStats characterObject)
    {
        Image.sprite = characterObject.Image;
        NameText.text = characterObject.Name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
