using UnityEngine;

namespace Vuforia
{
    /// <summary>
    /// A custom handler that implements the ITrackableEventHandler interface.
    /// </summary>
    public class SpeakerTrackableEventHandler : MonoBehaviour,
                                                ITrackableEventHandler
    {
        public GameObject SpeakerUiControls;
        private TrackableBehaviour mTrackableBehaviour;
        private GameObject CurrentTextUI = null;

        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
        }

        /// <summary>
        /// Implementation of the ITrackableEventHandler function called when the
        /// tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
            }
            else
            {
                OnTrackingLost();
            }
        }

        private void OnTrackingFound()
        {
            if (CurrentTextUI != null)
                return;

            CurrentTextUI = (GameObject)Instantiate(this.SpeakerUiControls);
            CurrentTextUI.SetActive(true);

            CurrentTextUI.transform.position = transform.position;
            CurrentTextUI.transform.rotation = transform.rotation;

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
        }
        
        private void OnTrackingLost()
        {
        }
    }
}
