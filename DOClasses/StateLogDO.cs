using BeerProductionSystem.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;

namespace BeerProductionSystem.DOClasses
{
    [Table("StateLog")]
    public partial class StateLogDO
    {
        [Key]
        [Column("StateLogID", Order = 0)]
        public int StateLogID { get; set; }
        [Required]
        [Column("BatchReportID", Order = 1)]
        public int BatchReportID { get; set; }
        public virtual BatchDO BatchReport { get; set; }
        [Column("DeactivatedState", Order = 2)]
        public Int64? DeactivatedState { get; set; }
        [Column("ClearingState", Order = 3)]
        public Int64? ClearingState { get; set; }
        [Column("StoppedState", Order = 4)]
        public Int64? StoppedState { get; set; }
        [Column("StartingState", Order = 5)]
        public Int64? StartingState { get; set; }
        [Column("IdleState", Order = 6)]
        public Int64? IdleState { get; set; }
        [Column("SuspendedState", Order = 7)]
        public Int64? SuspendedState { get; set; }
        [Column("ExecuteState", Order = 8)]
        public Int64? ExecuteState { get; set; }
        [Column("StoppingState", Order = 9)]
        public Int64? StoppingState { get; set; }
        [Column("AbortingState", Order = 10)]
        public Int64? AbortingState { get; set; }
        [Column("AbortedState", Order = 11)]
        public Int64? AbortedState { get; set; }
        [Column("HoldingState", Order = 12)]
        public Int64? HoldingState { get; set; }
        [Column("HeldState", Order = 13)]
        public Int64? HeldState { get; set; }
        [Column("ResettingState", Order = 14)]
        public Int64? ResettingState { get; set; }
        [Column("CompletingState", Order = 15)]
        public Int64? CompletingState { get; set; }
        [Column("CompleteState", Order = 16)]
        public Int64? CompleteState { get; set; }
        [Column("DeactivatingState", Order = 17)]
        public Int64? DeactivatingState { get; set; }
        [Column("ActivatingState", Order = 18)]
        public Int64? ActivatingState { get; set; }

        public StateLogDO()
        {
            this.SuspendedState = 0;
            this.StoppingState = 0;
            this.StoppedState = 0;
            this.StartingState = 0;
            this.ResettingState = 0;
            this.IdleState = 0;
            this.HoldingState = 0;
            this.HeldState = 0;
            this.ExecuteState = 0;
            this.DeactivatingState = 0;
            this.DeactivatedState = 0;
            this.CompletingState = 0;
            this.CompleteState = 0;
            this.ClearingState = 0;
            this.ActivatingState = 0;
            this.AbortingState = 0;
            this.AbortedState = 0;

        }

        public void SetTimeInStates(Dictionary<int, TimeSpan> dict)
        {
            this.DeactivatedState += dict[(int)MachineState.Deactivated].Ticks;
            this.ClearingState += dict[(int)MachineState.Clearing].Ticks;
            this.StoppedState += dict[(int)MachineState.Stopped].Ticks;
            this.StartingState += dict[(int)MachineState.Starting].Ticks;
            this.IdleState += dict[(int)MachineState.Idle].Ticks;
            this.SuspendedState += dict[(int)MachineState.Suspended].Ticks;
            this.ExecuteState += dict[(int)MachineState.Execute].Ticks;
            this.StoppingState += dict[(int)MachineState.Stopping].Ticks;
            this.AbortingState += dict[(int)MachineState.Aborting].Ticks;
            this.AbortedState += dict[(int)MachineState.Aborted].Ticks;
            this.HoldingState += dict[(int)MachineState.Holding].Ticks;
            this.HeldState += dict[(int)MachineState.Held].Ticks;
            this.ResettingState += dict[(int)MachineState.Resetting].Ticks;
            this.CompletingState += dict[(int)MachineState.Completing].Ticks;
            this.CompleteState += dict[(int)MachineState.Complete].Ticks;
            this.DeactivatingState += dict[(int)MachineState.Deactivating].Ticks;
            this.ActivatingState += dict[(int)MachineState.Activating].Ticks;

        }
    }
}
