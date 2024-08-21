using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Prefabs.EnterCodeArea
{
    public class Sample2 : MonoBehaviour
    {
        public Button back, finish;
        public GameObject previousView;
        public TMP_InputField firstName, lastName, identityNumber;
        
        private void Start()
        {
            finish.onClick.AddListener(Finish);
            
            back.onClick.AddListener(() =>
            {
                gameObject.SetActive(false);
                previousView.SetActive(true);
            });
        }
        
        private void Finish()
        {
            if (string.IsNullOrEmpty(firstName.text))
            {
                firstName.Select();
                firstName.ActivateInputField();
                return;
            }

            if (string.IsNullOrEmpty(lastName.text))
            {
                lastName.Select();
                lastName.ActivateInputField();
                return;
            }

            if (string.IsNullOrEmpty(identityNumber.text))
            {
                identityNumber.Select();
                identityNumber.ActivateInputField();
                return;
            }
        
            Debug.Log("FirstName: " + firstName.text + " LastName: " + lastName.text+ " IdentityNumber: " + identityNumber.text);
        }
    }
}
