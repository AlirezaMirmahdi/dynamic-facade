using BOLProject.BOL.SystemBOL.Facade;

namespace BOLProject.BOL.BaseBol
{
    public class BaseBol : IBaseBol
    {
        private Facade _facade;
        public Facade facade
        {
            get
            {
                return _facade;
            }
            set
            {
                _facade = value;
            }
        }

        public BaseBol(Facade facade)
        {
            this.facade = facade;
        }
    }
}
