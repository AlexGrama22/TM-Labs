
using UnityEngine;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    public Toggle toggle;
    private bool isToggled = true;
    public bool tick = false;

    void Start()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        //  toggle.onValueChanged.AddListener(delegate { ToggleValueChanged(toggle); });
=======
         toggle.onValueChanged.AddListener(delegate { ToggleValueChanged(toggle); });
>>>>>>> 984eb3ad62d8fe6f824d369539174d6c5f47f730
=======
         toggle.onValueChanged.AddListener(delegate { ToggleValueChanged(toggle); });
>>>>>>> 984eb3ad62d8fe6f824d369539174d6c5f47f730
    }

    public void ToggleValueChanged(Toggle toggle)
    {
        isToggled = toggle.isOn;
        if (isToggled)
        {
            Debug.Log("Checkbox is checked");
            tick = false;
        }
        else
        {
            Debug.Log("Checkbox is unchecked");
            tick = true;
        }
    }
}


