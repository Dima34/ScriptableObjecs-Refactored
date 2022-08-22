using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MerchantUI : MonoBehaviour
{
    [SerializeField] Text _swordNameText;
    [SerializeField] Text _swordDescriptionText;
    [SerializeField] Text _goldAmountText;
    [SerializeField] Text _damageText;
    [SerializeField] Image _swordIcon;

    public void FillUI(SwordData swordData){
        Debug.Log("Hmmm... Sword clicked... I should do something...");
    }
}
