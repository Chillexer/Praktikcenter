using UnityEngine;
using UnityEngine.Video;

public class pause : MonoBehaviour {
    public VideoPlayer player;
    private SteamVR_TrackedController device;
    private int count = 2;
    private float[] value = {0.1f, 0.5f, 1f, 2f, 4f, 8f };
    // Use this for initialization
    void Start () {
        device = GetComponent<SteamVR_TrackedController>();
        device.TriggerClicked += Device_TriggerClicked;
        device.PadTouched += Device_PadTouched;
	}


    private void Device_PadTouched(object sender, ClickedEventArgs e)
    {
        
        if (e.padX < 0 && count > 0) count--;
        else if (e.padX > 0 && count < 5) count++;
        player.playbackSpeed = value[count];
    }

    private void Device_TriggerClicked(object sender, ClickedEventArgs e)
    {
        if (player.isPlaying)
        {
            player.Pause();
            return;
        }
        player.Play();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
