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

        public StateLog()
        {
            this.AbortedState = 0;
            this.AbortingState = 0;
            this.ActivatingState = 0;
            this.ClearingState = 0;
            this.CompleteState = 0;
            this.CompletingState = 0;
            this.DeactivatedState = 0;
            this.DeactivatingState = 0;
            this.ExecuteState = 0;
            this.HeldState = 0;
            this.HoldingState = 0;
            this.IdleState = 0;
            this.ResettingState = 0;
            this.StartingState = 0;
            this.StoppedState = 0;
            this.StoppingState = 0;
            this.SuspendedState = 0;
            
        }
        public void SetTimeInStates(Dictionary<int, TimeSpan> dict)
        {
            //AbortedState += (float)dict[0].TotalSeconds;
            // Implement this.. TODO
        }
    }
}
