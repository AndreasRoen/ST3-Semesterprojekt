using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.DOClasses
{
    [Table("StateLog")]
    public partial class StateLog
    {
        [Key]
        public int StateLogID { get; set; }

        public int BatchReportID { get; set; }

        public float? DeactivatedState { get; set; }
        public float? ClearingState { get; set; }
        public float? StoppedState { get; set; }
        public float? StartingState { get; set; }
        public float? IdleState { get; set; }
        public float? SuspendedState { get; set; }
        public float? ExecuteState { get; set; }
        public float? StoppingState { get; set; }
        public float? AbortingState { get; set; }
        public float? AbortedState { get; set; }
        public float? HoldingState { get; set; }
        public float? HeldState { get; set; }
        public float? ResettingState { get; set; }
        public float? CompletingState { get; set; }
        public float? CompleteState { get; set; }
        public float? DeactivatingState { get; set; }
        public float? ActivatingState { get; set; }

        public virtual BatchReport BatchReport { get; set; }
    
     public void setTimeInStates(Dictionary<int, TimeSpan> dict)
        {
            AbortedState += (float)dict[0].TotalSeconds;
            // Implement this.. TODO
        }
    }
}
