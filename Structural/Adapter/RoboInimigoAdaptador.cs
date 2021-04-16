using System;

namespace Adapter
{
    // Classe Adapter = Classe que será o adaptador do objeto
    public class RoboInimigoAdaptador : IAtaqueInimigo
    {
        RoboInimigo robo;
        //Passar para o construtor o objeto que será adaptado
        public RoboInimigoAdaptador(RoboInimigo novoRobo)
        {
            this.robo = novoRobo;
        }

        public void ArmaFogo()
        {
            this.robo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            this.robo.AndarFrente();
        }

        public void Pilotar(string piloto)
        {
            this.robo.ReagirContraHumano(piloto);
        }
    }
}
