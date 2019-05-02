using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoED2Calculadora
{
    class PilhaVetor
    {
        private int posicoes;
        private Object[] P;
                           
        private int topo = -1;

        public PilhaVetor(int posic)
        {
            posicoes = posic; 
            P = new Object[posicoes];   
        } 

        public int tamanho()
        { 
            return (topo + 1);
        }
        public bool estaVazia()
        { 
            return (topo < 0);
        }
        public void empilhar(Object o)
        {
            if (tamanho() == posicoes)
                throw new Exception();
            P[++topo] = o; 
        }
        public Object oTopo()
        {
             Object o;
            if (estaVazia())
                throw new Exception();
            o = P[topo];
                return o;
        }
        public Object desempilhar()
        {
            Object o;
            if (estaVazia())
                throw new Exception();
            o = P[topo]; 
            P[topo] = null;
            topo--;
            return o; 
        }
         
    }
}
