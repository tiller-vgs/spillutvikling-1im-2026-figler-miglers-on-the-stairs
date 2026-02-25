using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public bool isActive;
    public Image foreGround;

    public void DisableHealth()
    {
        isActive = false;
        foreGround.gameObject.SetActive(false);
    } 

    public void Activehealth()
    {
        isActive = true;
        foreGround.gameObject.SetActive(true);
    }


}
