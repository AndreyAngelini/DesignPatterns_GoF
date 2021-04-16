using System;

namespace Builder
{
    public class iPhoneBuilder : ICelular
    {
        Celular celular;
        public Celular Celular {
            get { return this.celular; }
        }

        public iPhoneBuilder()
        {
            this.celular = new Celular("iPhone");
        }

        public void BuildBateria()
        {
            this.celular.bateria = "MAH2500";
        }

        public void BuildCamera()
        {
            this.celular.camera = "16mp";
        }

        public void BuildSistema()
        {
            this.celular.sistema = "iOS 11";
        }

        public void BuildTela()
        {
            this.celular.tela = "9";
        }
    }
}
