using UnityEngine;
using UnityEngine.UI;

namespace Prefabs.EnterCodeArea
{
    public class Sample1 : MonoBehaviour
    {
        public InputFieldManager inputFieldManager;
        public Button submit;
        public GameObject nextView;

        private void Start()
        {
            submit.onClick.AddListener(Submit);
        }

        private void Submit()
        {
            string code = inputFieldManager.GetCode();
            if (code.Length != 4)
            {
                inputFieldManager.ActivateFirstEmptyInputField();
                return;
            }
        
            Debug.Log("Code: " + code);
        
            gameObject.SetActive(false);
            nextView.SetActive(true);
        }
    }
}
