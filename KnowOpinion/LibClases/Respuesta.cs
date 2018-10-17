﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class Respuesta
    {

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Respuesta(int id, int v, string d)
        {
            if (v >= 1 && v <= 4)
            {
                this.valoracion = v;
            }
            else
            {
                this.valoracion = 0;
            }

            this.id = id;
            this.descripcion = d;
        }

        private int valoracion;
        public int Valoracion
        {
            get { return valoracion; }
            set
            {
                if (value >= 1 && value <= 4)
                {
                    this.valoracion = value;
                }
                else
                {
                    this.valoracion = 0;
                }
            }
        }
        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { this.descripcion = value; }
        }

    }
}
