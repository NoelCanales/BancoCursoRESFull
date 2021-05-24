using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Cliente : AuditableBaseEntity

    {
        private int _edad;
        public string NOmbre { get; set; }
        public String Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }
        public String Direccion { get; set; }

        public int Edad

        {
            get
            {
                if (this._edad <= 0)
                {
                    this._edad = new DateTime(DateTime.Now.Subtract(this.FechaNacimiento).Ticks).Year - 1;
                }
                return this._edad;


            }

        }

    }
}