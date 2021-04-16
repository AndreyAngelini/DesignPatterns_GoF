using System;

namespace Decorator
{
    // É o DECORATOR ABSTRATO
    public class Decorator : ItemBiblioteca
    {
        protected ItemBiblioteca itemBiblioteca;

        public Decorator(ItemBiblioteca itembiblioteca)
        {
            this.itemBiblioteca = itembiblioteca;
        }
        public override void Exibe()
        {
            this.itemBiblioteca.Exibe();
        }
    }
}
