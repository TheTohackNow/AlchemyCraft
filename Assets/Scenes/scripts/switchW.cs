using UnityEngine;

public class switchW : MonoBehaviour
{
    public bool switchState = false;
    public int current = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            drop scrpt = gameObject.GetComponent<drop>();
            melee scrptM = gameObject.GetComponent<melee>();
            switch (current)
            {
                
                case 0:
                    
                    scrptM.enabled = true;
                    scrpt.enabled = false;
                    switchState = false;
                    current = 1;
                    break;
                case 1:
                    
                    scrpt.enabled = true;
                    scrptM.enabled = false;
                    switchState = true;
                    current = 0;
                    break;
            }
        }
    }
}
