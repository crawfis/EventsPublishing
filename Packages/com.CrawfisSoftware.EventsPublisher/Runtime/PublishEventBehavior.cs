using UnityEngine;

namespace GTMY.EventManagement
{
    internal class PublishEventBehavior : MonoBehaviour
    {
        [SerializeField] private string defaultEventName = "";

        public void PublishEvent(string eventName)
        {
            EventsPublisher.Instance.PublishEvent(eventName is null ? defaultEventName : eventName, gameObject, null);
        }
    }
}
