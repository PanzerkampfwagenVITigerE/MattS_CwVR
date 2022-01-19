public int RepeatTimes = 0;

public void RepeatTimer()
{
    for (int i = 0; i < RepeatTimes; i++)
    {
        if (RepeatTimes > 0)
        {
            RestartTimer();
            Debug.Log("Restart");
        }

        else
        {
            DisableTimer();
            Debug.Log("DisableMe");
        }
    }
}
public void StartTimer()
{
    if (curTime >= duration)
    {
        curTime = 0;
    }
    timerPaused = false;
}
