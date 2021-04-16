using System;

namespace Builder
{
    public class AndriodBuilder : ICelular
    {
        Celular celular;
        public Celular Celular
        {
            get { return this.celular; }
        }

        public AndriodBuilder()
        {
            this.celular = new Celular("Android");
        }

        public void BuildBateria()
        {
            this.celular.bateria = "MAH1500";
        }

        public void BuildCamera()
        {
            this.celular.camera = "15mp";
        }

        public void BuildSistema()
        {
            this.celular.sistema = "Android 4.5";
        }

        public void BuildTela()
        {
            this.celular.tela = "7";
        }

    }
}
