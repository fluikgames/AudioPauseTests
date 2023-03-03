public class README 
{
    // The purpose of this project is to determine 
    // how to best pause, unpause, play sounds
    // and how pausing the audiolistener affects audio sources

    // Play and Pause on a Paused Audio Resume
    // Play on a Playing Audio resets to beginning and plays
    // Stop on a Playing Audio resets to beginning and stops

    // isPlaying will be set to false if the AudioListener.pause = true
    // AudioSource.time however is only 0 when stopped
    // AudioSource.time will be greater than zero if AudioListener is paused
    // AudioSource.time is only 0 when stopped, not when paused or game paused
}
