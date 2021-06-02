namespace AulaObjetosComoArgumento.classes
{
    public class equipamento
    {
        public string nome {get; set;}
        public int raridade {get; set;}
        public int level {get; set;}
        public string passiva {get; set;}
        public string ativa {get; set;}
        public int itemID {get; set;}
        public equipamento(){

        }
        public equipamento(string Nome, int Raridade, int Level, string Passiva, string Ativa, int ItemID){
            this.nome = Nome;
            this.raridade = Raridade;
            this.level = Level;
            this.passiva = Passiva;
            this.ativa = Ativa;
            this.itemID = ItemID;
        }
    }
}