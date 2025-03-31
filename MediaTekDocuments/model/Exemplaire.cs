﻿using System;

namespace MediaTekDocuments.model
{
    public class Exemplaire
    {
        public int Numero { get; set; }

        public string Photo { get; set; }

        public DateTime DateAchat { get; set; }

        public string IdEtat { get; set; }

        public string Id { get; set; }

        public string Libelle { get; set; }

        public Exemplaire(int numero, DateTime dateAchat, string photo, string idEtat, string idDocument, string libelle)
        {
            this.Numero = numero;
            this.DateAchat = dateAchat;
            this.Photo = photo;
            this.IdEtat = idEtat;
            this.Id = idDocument;
            this.Libelle = libelle;
        }

    }
}
