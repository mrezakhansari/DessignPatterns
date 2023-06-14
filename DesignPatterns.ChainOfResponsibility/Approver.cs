using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver Supervisor;

        public void SetSupervisor(Approver supervisor)
        {
            this.Supervisor = supervisor;   
        }

        public abstract void ProcessRequest(PurchaseOrder purchase);
    }
}