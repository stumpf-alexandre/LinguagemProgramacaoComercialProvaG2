using System;
using System.Collections.Generic;

namespace g2.Alexandre.Domain
{
    public class TarefaPendente
    {
        public int id{get;set;}

        public int prioridade{get;set;}

        public string nomeTarefa{get;set;}

        public string dataExec{get;set;}

        public int percentual{get;set;}
    }
}