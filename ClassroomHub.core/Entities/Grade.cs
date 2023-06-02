using System;

namespace ClassroomHub.Core.Entities
{
	public class Grade : EntityBase
    {
        public Guid DeliveryId { get; set; }
        public Delivery Delivery { get; set; }

        public int GradeValue { get; set; }
    }
}
