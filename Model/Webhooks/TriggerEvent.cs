using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafetyCulture.Model.Webhooks
{
  
    public class TriggerEvent
    {
        public static TriggerEvent InspectionStarted = new TriggerEvent("TRIGGER_EVENT_INSPECTION_STARTED");
        public static TriggerEvent InspectionUpdated = new TriggerEvent("TRIGGER_EVENT_INSPECTION_UPDATED");
        public static TriggerEvent InspectionCompleted = new TriggerEvent("TRIGGER_EVENT_INSPECTION_COMPLETED");
        public static TriggerEvent InspectionArchived = new TriggerEvent("TRIGGER_EVENT_INSPECTION_ARCHIVED ");
        public static TriggerEvent InspectionUnarchived = new TriggerEvent("TRIGGER_EVENT_INSPECTION_UNARCHIVED ");


        private string t;
        private TriggerEvent (string s)
        {
            t = s;
        }
    }
}
