using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupStartMenu : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    [SerializeField] private Image characterSprite;
    [SerializeField] private GameObject infomation;
    [SerializeField] private GameObject selectCharacter;

    private CharacterType characterType;    

    public void OnClickCharacter()
    {
        infomation.SetActive(false);
        selectCharacter.SetActive(true);
    }

    public void OnClickSelectCharacter(int index)
    {
        characterType = (CharacterType)index;
        var character = GameManager.Instance.CharacterList.Find(item => item.ChartacterType == characterType);
        characterSprite.sprite = character.CharacterSprite;
        characterSprite.SetNativeSize();

        selectCharacter.SetActive(false);
        infomation.SetActive(true);
    }

    public void OnclickJoin()
    {
         if(!(2 < inputField.text.Length && 10 > inputField.text.Length))
        {
            return;
        }
         GameManager.Instance.SetCharacter(characterType, inputField.text);

        Destroy(gameObject);    
    }
}
