﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_05_Serializacion_XML_con_composicion
{
        [Serializable]
        public class CAuto
        {
            private double costo;
            private string modelo;
            private CMotor motor;

            public double Costo
            {
                get { return costo; }
                set { costo = value; }
            }

            public string Modelo
            {
                get { return modelo; }
                set { modelo = value; }
            }

        // Es importante colocar la propiedad del objeto que hace composicion
            public CMotor Motor
            {
                get { return motor; }
                set { motor = value; }
            }

            // Constructor
            public CAuto()
            {
                // Inicializamos los datos
                modelo = "Vocho";
                costo = 100000;
                motor = new CMotor();
            }

        // Sobrecarga de constructor
        public CAuto(string pModelo, double pCosto, int pCilindros, int pHP)
        {
            modelo = pModelo;
            costo = pCosto;
            motor = new CMotor(pCilindros, pHP);
        }

            public void MuestraInformacion()
            {
                // Mostramos la informacion necesaria
                Console.WriteLine("Tu Automovil {0}", modelo);
                Console.WriteLine("Costo {0} ", costo);
                motor.MuestraMotor();
                Console.WriteLine("-----------------");
            }
        }
    }
