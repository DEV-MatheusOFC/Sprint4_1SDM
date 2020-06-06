namespace CelularPOO
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;

        /// <sumary>
        /// Liga o Celular
        /// </sumary>
        /// <returns> Altera o estado do Celular e retorna um texto </returns>
        public string Ligar(){
            ligado = true;
            return "Ligando Celular";
        }

        /// <summary>
        /// Desliga o celular
        /// </summary>
        /// <returns> Altera o estado do Celular e retorna um texto</returns>
        public string Desligar(){
            ligado = false;
            return "Desligando Celular";
        }

        /// <summary>
        /// Envia mensagem
        /// </summary>
        /// <returns>retorna texto de mensagem enviada</returns>
        public string EnviarMensagem(){
            return "Enviando Mensagem";
        }    

        /// <summary>
        /// Realiza ligação
        /// </summary>
        /// <returns>retorna texto de ligação sendo realizada</returns> 
        public string FazerLigacao(){
            return "Ligando para Contato";
        } 


    }     
}