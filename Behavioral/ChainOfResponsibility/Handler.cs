using System;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler sucessor;
        public void SetSucessor(Handler pSucessor)
        {
            this.sucessor = pSucessor;
        }

        public abstract void HandlerRequest(int request);
    }
}
