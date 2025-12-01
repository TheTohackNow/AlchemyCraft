using UnityEngine;

public class switchW : MonoBehaviour
{
    public bool switchState = false;
    public int current = 1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            drop scrpt = gameObject.GetComponent<drop>();
            melee scrptM = gameObject.GetComponent<melee>();
            range scrptR = gameObject.GetComponent<range>();

            switch (current)
            {
                
                case 0:
                    
                    scrptM.enabled = true;
                    scrpt.enabled = false;
                    scrptR.enabled = false;
                    switchState = false;
                    current = 1;
                    break;
                case 1:
                    
                    scrpt.enabled = true;
                    scrptM.enabled = false;
                    scrptR.enabled = false;
                    switchState = true;
                    current = 2;
                    break;
                case 2:

                    scrptR.enabled = true;
                    scrptM.enabled = false;
                    scrpt.enabled = false;
                    switchState = true;
                    current = 0;
                    break;
            }
        }
    }
}
