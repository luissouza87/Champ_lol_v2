﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmirTrabalho.Camadas.BLL
{
    public class jogador
    {
        public List<MODEL.Jogadores> Select()
        {
            DAL.Jogador dalJogador = new DAL.Jogador();
            // escrever regras de negócios
            return dalJogador.Select();
        }

        public void Insert(MODEL.Jogadores Jogador)
        {
            DAL.Jogador dalJogador = new DAL.Jogador();
            //regras de negocio
            dalJogador.Insert(Jogador);
        }

        public void Update(MODEL.Jogadores Jogador)
        {
            DAL.Jogador dalJogador = new DAL.Jogador();
            //regras de negócio
            dalJogador.Update(Jogador);
        }

        public void Delete(MODEL.Jogadores Jogador)
        {
            DAL.Jogador dalJogador = new DAL.Jogador();
            // regras de negócio
            dalJogador.Delete(Jogador);
        }
    }
}
