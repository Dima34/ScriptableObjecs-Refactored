using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MerchantUI : MonoBehaviour
{
    [SerializeField] Text _swordNameText;
    [SerializeField] Text _swordDescriptionText;
    [SerializeField] Text _goldAmountText;
    [SerializeField] Text _damageText;
    [SerializeField] Image _swordIcon;

    public void FillUI(UnityEngine.Object objectedSwordData){
        // Check if the recieved object is a SwordData
        if(!(objectedSwordData is SwordData)){
            return;
        }

        SwordData swordData = (SwordData)objectedSwordData;

        _swordNameText.text = swordData.SwordName;
        _swordDescriptionText.text = swordData.Description;
        _goldAmountText.text = swordData.GoldCost.ToString();
        _damageText.text = swordData.AttackDamage.ToString();
        _swordIcon.sprite = swordData.Icon;
    }
}
