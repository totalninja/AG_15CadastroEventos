namespace AG_15CadastroEventos.NovaPasta1
{
    public class Evento
    {
        public String NomeEvento { get; set; }
        public DateTime Datacomeco { get; set; }
        public DateTime DataFinal { get; set; }
        public int QtdParticipantes { get; set; }
        public string LocalEvento { get; set; }
        //  Não consegui usar o TimeSpan de jeito nenhum!
        public int ValorTotal
        {
            get
            {
                TimeSpan diferenca = DataFinal - Datacomeco;
                int Duracao = diferenca.Days;
                return QtdParticipantes * 50 + (Duracao * 30); 
            }
        }
       
        
    }

}
