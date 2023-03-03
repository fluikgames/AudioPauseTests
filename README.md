# AudioPauseTests

Purpose of project is to see how AudioSource.IsPlaying reacts to pauses in AudioListener and/or AudioSource.  Findings can be found in the README.cs script.    
If you want to know if an audiosource was playing when the game was paused, it appears you need to check value of AudioSource.time, not .isPlaying.
