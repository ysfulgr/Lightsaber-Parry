using System;
using System.Collections.Generic;

public enum EventNames
{
    EventSpawnParticle, EventSimulate, EventSimulateOther, LightsaberAngle, LightsaberAngleOther,
    EventCollisionMessage, EventAnimationEnable, EventAnimationEnableOther
}
public static class EventManager
{
    public static Dictionary<EventNames, Delegate> e_EventDictionary = new Dictionary<EventNames, Delegate>();

    public static void CallEvent<T>(EventNames eventName, T param)
    {
        e_EventDictionary[eventName].DynamicInvoke(param);
    }

    public static void AddEvent<T>(EventNames eventName, Action<T> action)
    {
        if (!CheckEventName(eventName, e_EventDictionary))
            e_EventDictionary.Add(eventName, action);
    }

    static bool CheckEventName(EventNames eventName, IDictionary<EventNames, Delegate> dictionary)
    {
        if (dictionary.ContainsKey(eventName))
            return true;
        return false;
    }

}
