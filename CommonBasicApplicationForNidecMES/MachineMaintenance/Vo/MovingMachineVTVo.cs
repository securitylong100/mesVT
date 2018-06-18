using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo
{
    public class MovingMachineVTVo : ValueObject
    {
        public int MovingId { get; set; }
        public string MachineSerial { get; set; }
        public string TranferFactoryCode { get; set; }
        public string ReceivedFactoryCode { get; set; }
        public string BGCode { get; set; }
        public string MCode { get; set; }
        public string TCode { get; set; }
        public string THCode { get; set; }
        public string StatusMachine { get; set; }
        public string CommentsMachine { get; set; }
        public string ReasonTranfer { get; set; }
        public string ConfirmReceived { get; set; }
        public string RegistrationUserCode { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public string FactoryCode { get; set; }


        public int AffectedCount { get; set; }
        /// <summary>
        /// //check RFid
        /// </summary>


        public List<MovingMachineVTVo> movingmachinevtVo = new List<MovingMachineVTVo>();
    }
}