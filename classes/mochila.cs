using System;
using System.Collections.Generic;

namespace AulaObjetosComoArgumento.classes
{
    public class mochila
    {
        public float nivelTotal {get; set;}
        
        List<equipamento> _mochila = new List<equipamento>();

        public void adicionarEquipamento(equipamento equipamento){
            _mochila.Add(equipamento);
        }
        public void removerEquipamento(equipamento equipamento){
            _mochila.Remove(equipamento);
        }
        public void mostarMochila(){
            if (_mochila!= null)
            {
                foreach (equipamento p in _mochila)
                {
                    Console.WriteLine($@"
                    ===================================
                    Nome    - {p.nome}
                    Rarida  - {p.raridade}
                    Level   - {p.level}
                    Passiva - {p.passiva}
                    Ativa   -  {p.ativa}
                    ID      - {p.itemID}
                    ====================================");
                }
            }
            else
            {
                Console.WriteLine("Não há equipamentos na mochila!!!");
            }
        }
        public void mostrarLevelTotal(){
            if (_mochila != null)
            {
                foreach (equipamento p in _mochila)
                {
                    nivelTotal += p.level;
                }
                    Console.WriteLine($"O nível total é igual a {nivelTotal}");
            }
            else
            {
                Console.WriteLine("Não há itens, portanto, não há um nível definido!!!");
            }
        }
        public void alterarEquipamento(int id, equipamento novoEquipamento){
            _mochila.Find(equipamento => id == equipamento.itemID).level = novoEquipamento.level;
            _mochila.Find(equipamento => id == equipamento.itemID).passiva = novoEquipamento.passiva;
            _mochila.Find(equipamento => id == equipamento.itemID).ativa = novoEquipamento.ativa;
        }
    }
}