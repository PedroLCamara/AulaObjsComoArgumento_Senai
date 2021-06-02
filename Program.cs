using System;
using System.Collections.Generic;
using AulaObjetosComoArgumento.classes;

namespace AulaObjetosComoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            equipamento a = new equipamento("Espada de 10m", 5, 100, "Espada a longo alcance", "Golpeia o chão levantando inimigos menores", 1);
            equipamento b = new equipamento("Arco de mármore celestial", 5, 100, "Flechas mais rápidas", "Flechas perfuram inimigos por 3s", 2);
            equipamento c = new equipamento("Armadura do Troll", 5, 100, "Aumento de tamanho e vida", "Força aumenta em 35% por 20s", 3);

            mochila m = new mochila();
            m.adicionarEquipamento(a);
            m.adicionarEquipamento(b);
            m.adicionarEquipamento(c);

            m.mostarMochila();
        }
    }
}
