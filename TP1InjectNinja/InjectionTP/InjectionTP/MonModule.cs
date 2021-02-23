using Ninject.Modules;

namespace InjectionTP
{
    class MonModule : NinjectModule
    {
        public MonModule(int i)
        {
            switchMode = i;
        }
        public int switchMode
        {
            get;
            set;
        }
        public override void Load()
        {
            if(switchMode == 0)
            {
                Bind<IChargementParametres>().To<ChargementsParametres>();
            }
            else if(switchMode == 1)
            {
                Bind<IChargementParametres>().To<ChargementsParametresMode2>();
            }
        }
    }
}
