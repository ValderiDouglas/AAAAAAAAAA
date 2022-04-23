using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiFPS : MonoBehaviour
{
    private float timer, refresh, avgFramerate;
    private string display= "{0} FPS";
    public Text m_Text;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float timelapse= Time.smoothDeltaTime;
        timer= timer <= 0 ? refresh : timer -= timelapse;

        if(timer <=0 ) avgFramerate= (int)(1f/timelapse);
        m_Text.text= string.Format(display,avgFramerate.ToString());
    }
    
    public void Minecraft(){
    Screen.SetResolution(1920,1080,true);
    }
}
